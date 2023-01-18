namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {


            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            var productService = new ProductBusiness();
            var affectedRows = productService.AddProduct(name, price);
            var message = affectedRows > 0 ? "Kayıt başarılı" : "Kayıt gerçekleşmedi";
            MessageBox.Show(message);


            //Bir sınıf içinde değişiklik yapmak için birden fazla sebebiniz varsa; 
            //prensibi ihlal ediyorsunuz demektir.


        }
    }
}