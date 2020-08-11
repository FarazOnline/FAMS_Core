namespace FAMSWPF.Library.Models.Interfaces
{
    public interface IContact
    {
        string KeyPerson { get; set; }
        string BusinessName { get; set; }
        string CNIC { get; set; }
        string NTN { get; set; }
        string JobTitle { get; set; }
        string PlotAddress { get; set; }
        string StreetAddress { get; set; }
        string RegionAddress { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
        string EmailAddress { get; set; }
        string CellNumber { get; set; }
        string ResidNumber { get; set; }
        string WorkNumber { get; set; }
    }
}