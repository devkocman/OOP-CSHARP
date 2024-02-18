internal class Program
{
    //First Question
    /* public  class Animal  
       {
       public string animal_type;
       public string animal_habitat;
       public string animal_diet;

       public Animal(string animal_type, string animal_habitat, string animal_diet)
       {
           this.animal_type = animal_type;
           this.animal_habitat = animal_habitat;
           this.animal_diet = animal_diet;
           Console.WriteLine("animal type: "+animal_type+", animal habitat: "+animal_habitat+", animal diet: "+animal_diet);
       }

   }
   */

    //Secoond Question

    //class Product
    /*{
        public string product_name;
        public int product_price;
        public int product_stock_statu;
        public void Fiyathesapla(int new_price )
        {
            int old_price = 0;
            old_price = this.product_price;
            this.product_price = new_price;
            Console.WriteLine("old price "+old_price +" new price : " + product_price);
        }
        public void Stock_status(int product_sold)
        {
            int new_stock_statu = product_stock_statu - product_sold;
            Console.WriteLine("old_stock_statu "+product_stock_statu+ " product sold "+product_sold+" Product new stock statu " + new_stock_statu );
        }


    }*/
    //Third Questions
    //class customer
    //{
    //    public string customer_name;
    //    public string customer_surname;
    //    public string customer_email;
    //    public string customer_phone;
    //    public customer(string customer_name, string customer_surname, string customer_email, string customer_phone)
    //    {
    //        this.customer_name = customer_name;
    //        this.customer_phone = customer_phone;
    //        this.customer_email = customer_email;
    //        this.customer_surname = customer_surname;

    //        Console.WriteLine("object "+customer_name+" "+customer_surname+" "+customer_email+" "+customer_phone);
    //    }
    //    public void update_customer_name(string customer_name)
    //    {
    //       this.customer_name = customer_name;


    //        Console.WriteLine("new object " + customer_name + " " + customer_surname + " " + customer_email + " " + customer_phone);


    //    }
    //}

    //fourth question

    //class Car
    //{
    //    public string brand;
    //    public string model;
    //    public string rental_fee;
    //    public string rentable_status;

    //    public Car(string brand,string model,string rental_fee,string rentable_status)
    //    {
    //      this.brand = brand;
    //        this.model = model;
    //        this.rental_fee = rental_fee;
    //        this.rentable_status = rentable_status;
    //        Console.WriteLine("brand " + brand + " model " + model + " rental_fee " + rental_fee + " rentable_status " + rentable_status);
    //    }
    //    public void rentable_statu_update(string rentable_status)
    //    {
    //        this.rentable_status = rentable_status;
    //        Console.WriteLine("brand " + brand + " model " + model + " rental_fee " + rental_fee + " new_rentable_status " + rentable_status);
    //    }
    //}

    //fifth question

    //class employee
    //{
    //   public string employee_name;
    //    public string employee_surname;
    //    public string employee_position;
    //    public string employee_salary;

    //    public employee(string employee_name,string employee_surname,string employee_position,string employee_salary)
    //    {
    //        this.employee_name = employee_name;
    //        this.employee_surname = employee_surname;
    //        this.employee_position = employee_position;
    //        this.employee_salary = employee_salary;
    //        Console.WriteLine("employee name "+employee_name+" employee_surname "+employee_surname+ " employee_position " + employee_position+ " employee_salary " + employee_salary);
    //    }
    //    public void employee_position_update(string employee_position)
    //    {
    //        this.employee_position = employee_position;
    //        Console.WriteLine("employee name " + employee_name + " employee_surname " + employee_surname + " new_employee_position " + employee_position + " employee_salary " + employee_salary);
    //    }
    //}


    //sixth question
    //class BankAccount
    //{
    //    public string BankAccount_user;
    //    public string BankAccount_ISSN;
    //    public int Cash;



    //    public BankAccount(string BankAccount_user, string BankAccount_ISSN, int Cash)
    //    {
    //        this.BankAccount_user = BankAccount_user;
    //        this.BankAccount_ISSN = BankAccount_ISSN;
    //        this.Cash = Cash;

    //        Console.WriteLine("BankAccount_user " + BankAccount_user + " BankAccount_ISSN: " + BankAccount_ISSN + " Cash: " + Cash);
    //    }

    //    public void Cash_withdrawal(int cash_withdrawal)
    //    {
    //       Cash-=cash_withdrawal;
    //        Console.WriteLine("BankAccount_user " + BankAccount_user + " BankAccount_ISSN: " + BankAccount_ISSN + " New Cash: " + Cash);
    //    }
    //    public void deposit_cash(int dep_cash)
    //    {
    //        Cash += dep_cash;
    //        Console.WriteLine("BankAccount_user " + BankAccount_user + " BankAccount_ISSN: " + BankAccount_ISSN + " New Cash: " + Cash);
    //    }
    //}


    //seventh question
    //class shape
    //{
    //    public string name_of_geometric_shape;
    //    public int kenar_1;
    //    public int kenar_2;
    //    public shape(string name_of_geometric_shape, int kenar_1, int kenar_2)
    //    {
    //        this.name_of_geometric_shape = name_of_geometric_shape;
    //        this.kenar_1 = kenar_1;
    //        this.kenar_2 = kenar_2;
    //        Console.WriteLine(name_of_geometric_shape + " " + kenar_1 + " "+ kenar_2);
    //}
    //    public void area(int kenar_1,int kenar_2)
    //    {
    //        int area=kenar_1*kenar_2;
    //        Console.WriteLine("area "+area + " "+" kenar1 " + kenar_1 + " "+"kenar_2" + kenar_2);
    //        //if sorgusu sorularak şeklin alanları ve çevreleri farklı hesaplanabilir.
    //        //alan ve çevre metotlarına farklı bir değişken vermemiz ve bu değişkeni if sorgusu ile sorgulamamız yeterlidir.
    //    }
    //    public void environment(int kenar_1)
    //    {
    //        int environment = kenar_1 * 4;
    //        Console.WriteLine("environment " + environment + " " + " kenar1 " + kenar_1 );

    //    }
    //}

    //eighth

    class Weather
    {
        public string city_name;
        public int temperature;
        public string humidity;   
    
        public Weather(string city_name, int temperature, string humidity) 
        { 
            this.city_name = city_name;
            this.temperature = temperature;
            this.humidity = humidity;
            Console.WriteLine("city_name: "+city_name+" temperature "+temperature+" humidity "+humidity);
        }
        public void Temperature_decline(int temperature_Decline)
        {
        
            int new_temperature =  temperature - temperature_Decline;
            Console.WriteLine("new temperature "+new_temperature);
        }

    }



    private static void Main(string[] args)
    {
        //Animal animal = new Animal("leon","forest","meat"); First Question
        //Product product = new Product();
        //product.product_price = 13;
        //product.Fiyathesapla(10);
        //product.product_stock_statu = 10;
        //product.Stock_status(1);
        //customer ncust = new customer("ali", "akbulut", "aliakbulut@gmail.com", "1234567890");
        //ncust.update_customer_name("hakki");
        //Car car_one = new Car("Ford","Mustang","150$","true");
        //car_one.rentable_statu_update("false");
        //employee employee_one = new employee("adam", "smith", "clean_ofiice", "1000$");
        //employee_one.employee_position_update("ceo");
        //BankAccount the_bank=new BankAccount("alican","12356",1000);
        //the_bank.Cash_withdrawal(10);
        //the_bank.deposit_cash(1);
        //shape shape_kare = new shape("kare", 4, 4);
        //shape_kare.area(4, 4);
        //shape_kare.environment(4);
        Weather wet=new Weather("istanbul",12,"1.2");
        wet.Temperature_decline(1);
    }
}