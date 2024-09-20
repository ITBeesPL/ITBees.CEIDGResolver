namespace ITBees.CEIDGResolver;

public class Firma
{
    public Guid Id { get; set; } // ID firmy w formie GUID
    public string Nazwa { get; set; } // Nazwa firmy
    public AdresDzialalnosci AdresDzialalnosci { get; set; } // Adres działalności
    public Wlasciciel Wlasciciel { get; set; } // Właściciel firmy
    public DateTime DataRozpoczecia { get; set; } // Data rozpoczęcia działalności
    public string Status { get; set; } // Status firmy (np. AKTYWNY, ZAWIESZONY)
    public string Link { get; set; } // Link do szczegółów firmy
}