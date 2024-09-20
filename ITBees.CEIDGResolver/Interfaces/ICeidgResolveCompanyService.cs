namespace ITBees.CEIDGResolver.Interfaces;

public interface ICeidgResolveCompanyService
{
    Firma GetCompanyDetails(string NIP);
}