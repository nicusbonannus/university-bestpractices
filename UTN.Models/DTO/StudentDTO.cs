using System;

namespace UTN.Models.DTO
{
    public class StudentDTO
    {
        public int StudentId { set; get; }
        public int Code { set; get; }
        public DateTime? DateCreated { set; get; }
        public DateTime? DateUpdated { set; get; }

        public int CountryId { set; get; }

        public CountryDTO Country { set; get; }

        public StudentDTO() {
            DateCreated = DateTime.Now;
        }
    }
}
