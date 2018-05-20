namespace SampleDataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        private string _fullName;
        public string FullName
        {
            get {
                _fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                    _fullName = $"{_fullName} {LastName}";

                return _fullName;
            }
        }
    }
}
