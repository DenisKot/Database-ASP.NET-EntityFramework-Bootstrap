namespace DatabaseConnector
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        /// <summary>
        /// Ключ
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Імя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамілія
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// По батьові
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// e-mail 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Місто
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Країна
        /// </summary>
        public string Country { get; set; }
    }
}
