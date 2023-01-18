namespace SingleResponsibility
{
    public class ProductBusiness
    {
        public int AddProduct(string name, decimal price) => AddProduct(new Product { Name = name, Price = price });


        public int AddProduct(Product product)
        {
            var connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";
            var commandText = "INSERT into Products (ProductName, UnitPrice) values (@name,@price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", product.Name);
            parameters.Add("@price", product.Price);

            var affectedRows = new DbOperator(connectionString).Execute(commandText, parameters);

            return affectedRows;
        }
    }
}
