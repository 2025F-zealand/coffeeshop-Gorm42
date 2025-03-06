namespace AnimalLib
{
    public class Animal
    {
        /// <summary>
        /// The Id of the animal. Must be unique and greater than 0.
        /// </summary>
        private int _id;
        public int Id 
        {
            get { return _id; }
            set { if (value <= 0) 
                { 
                    throw new ArgumentOutOfRangeException("Id must be greater than 0"); 
                } 
                if (value == _id)
                { 
                    throw new ArgumentOutOfRangeException("Id must be unique.");
                }
                else 
                { _id = value; } }
 
        }
        /// <summary>
        /// The category of the animal. Must be at least 2 characters long.
        /// </summary>
        private string _category;
        public string Category 
        {
            get { return _category; }
            set 
            {
                if (value == null) 
                {
                    throw new ArgumentNullException("Category must have a value.");

                }
                if (value.Length <= 2)
                {
                    throw new ArgumentOutOfRangeException("Category must be at least 2 characters long.");
                }
                else
                {
                    value = _category; 
                }
            }
        }
        /// <summary>
        /// The age of the animal.
        /// </summary>
        private int _age;
        public int Age 
        {
            get { return _age; }
            set { value = _age; } 
        }
        /// <summary>
        /// Must be above 10 and less than 10000.
        /// </summary>
        private double _price;
        public double Price 
        {
            get { return _price; }
            set 
            {
                if (value <= 10 || value < 10000)
                {
                    value = _price;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price must be above 10 and less than 10000.");

                } 
            } 
        }

        public Animal(int id, string category, int age, double price)
        {
            Id = id;
            Category = category;
            Age = age;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Category: {Category}, Age: {Age}, Price: {Price}";
        }
    }
}
