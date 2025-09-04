using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncfusionBlazorCRUDApi.Data
{
    [Table("Employee")]

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
    }
}