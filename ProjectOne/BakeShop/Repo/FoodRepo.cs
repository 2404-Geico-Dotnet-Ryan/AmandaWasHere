using Microsoft.Data.SqlClient;
class FoodRepo
{
    private readonly string _connectionString;

    public FoodRepo(string connString)
    {
        _connectionString = connString;
    }

    public Food? AddItem(Food a)
    {
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        string sql = "INSERT INTO Food OUTPUT inserted.* VALUES (@ItemName, @Price, @InStock";

        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@ItemName", a.ItemName);
        cmd.Parameters.AddWithValue("@Price", a.Price);
        cmd.Parameters.AddWithValue("@InStock", a.InStock);

        using SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            Food bakeryItems = BuildItem(reader);
            return a;
        }
        else
        {
            return null;
        }
    }

    public Food? ViewItem(int id)
    {
        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Food WHERE Id = @Id";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Food bakeryItems = BuildItem(reader);
                return bakeryItems;
            }

            return null;

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public List<Food> ViewAll()
    {
        List<Food> bakeryItems = [];
        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Food";
            using SqlCommand cmd = new(sql, connection);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Food newItem = BuildItem(reader);
                bakeryItems.Add(newItem);
            }

            return bakeryItems;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public Food? UpdateItem(Food u)
    {
        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "UPDATE Food SET ItemName = @ItemName, Price = @Price, InStock = @InStock OUTPUT inserted.* WHERE Id = @Id";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", u.Id);
            cmd.Parameters.AddWithValue("@ItemName", u.ItemName);
            cmd.Parameters.AddWithValue("@Price", u.Price);
            cmd.Parameters.AddWithValue("@InStock", u.InStock);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Food newItem = BuildItem(reader);
                return newItem;
            }

            return null;

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }
    public Food? DeleteItem(Food c)
    {
        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "DELETE FROM Food OUTPUT deleted.* WHERE Id = @Id";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", c.Id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Food bakeryItems = BuildItem(reader);
                return bakeryItems;
            }

            return null;

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    //Helper

    private Food BuildItem(SqlDataReader reader)
    {
        Food newItem = new();
        newItem.Id = (int)reader["Id"];
        newItem.ItemName = (string)reader["ItemName"];
        newItem.Price = (double)((decimal)reader["Price"]);
        newItem.InStock = (bool)reader["InStock"];

        return newItem;
    }


    // BakedGoods bakedGoods = new();

    // public Food AddItem(Food a)
    // {
    //     a.Id = bakedGoods.idCounter++;

    //     bakedGoods.bakeryItems.Add(a.Id, a);
    //     return a;
    // }
    // public Food? ViewItem(int id)
    // {
    //     if (bakedGoods.bakeryItems.ContainsKey(id))
    //     {
    //         Food selectedItem = bakedGoods.bakeryItems[id];
    //         return selectedItem;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Sorry, we don't have that item.");
    //         return null;
    //     }
    // }
    // //VIEW CART
    // public List<Food> ViewAll()
    // {
    //     return bakedGoods.bakeryItems.Values.ToList();
    // }
    // public Food? UpdateItem(Food b)
    // {
    //     try
    //     {
    //         bakedGoods.bakeryItems[b.Id] = b;
    //         return b;
    //     }
    //     catch (Exception)
    //     {
    //         Console.WriteLine("Sorry, we don't have that item.");
    //         return null;
    //     }

    // }
    // public Food? DeleteItem(Food c)
    // {
    //     bool didRemove = bakedGoods.bakeryItems.Remove(c.Id);

    //     if (didRemove)
    //     {
    //         return c;
    //     }
    //     else
    //     {
    //         Console.WriteLine("This item is not in your cart.");
    //         return null;
    //     }
    // }
}
