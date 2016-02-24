using System.Collections.Generic;

namespace UTN.Models.DTO
{
    public class CountryDTO
    {
        public int CountryId { set; get; }

        public string Name { set; get; }

        public virtual List<StudentDTO> Students { set; get; }
    }
}