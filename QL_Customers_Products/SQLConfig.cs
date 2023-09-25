using System;
using System.Data;
using System.Data.SqlClient;

public class SQLConfig
{
    SqlConnection connection = new SqlConnection("Server=VANANH;Database=QLKH_SP;User Id=sa;Password=123;");
    //Truy vấn
    public void ExecuteNonQuery(string query)
    {
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Lỗi SQL: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
    }
    // Lấy bảng dữ liệu
    public DataTable ExecuteTableQuery(string query)
    {
        DataTable dataTable = new DataTable();

        try
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Lỗi SQL: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
        return dataTable;
    }
    //Lấy 1 kiểu dữ liệu
    public object ExecuteScalar(string query)
    {
        object result = null;

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            result = command.ExecuteScalar();
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Lỗi SQL: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
        return result;
    }
}
