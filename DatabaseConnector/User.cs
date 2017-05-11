namespace DatabaseConnector
{
    using System.ComponentModel;
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
        [DisplayName("Імя")]
        public string Name { get; set; }

        /// <summary>
        /// Прізвище
        /// </summary>
        [DisplayName("Прізвище")]
        public string Surname { get; set; }

        /// <summary>
        /// По батьові
        /// </summary>
        [DisplayName("По батьові")]
        public string LastName { get; set; }

        /// <summary>
        /// e-mail 
        /// </summary>
        [DisplayName("e-mail")]
        public string Email { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        [DisplayName("Назва")]
        public string Phone { get; set; }

        /// <summary>
        /// Місто
        /// </summary>
        [DisplayName("Місто")]
        public string City { get; set; }

        /// <summary>
        /// Країна
        /// </summary>
        [DisplayName("Країна")]
        public string Country { get; set; }
    }
}
