namespace ITBees.CEIDGResolver;

public class AdresDzialalnosci
{
    public string Ulica { get; set; } // Ulica
    public string Budynek { get; set; } // Numer budynku
    public string Lokal { get; set; } // Numer lokalu (opcjonalny)
    public string Miasto { get; set; } // Miasto
    public string Wojewodztwo { get; set; } // Województwo
    public string Powiat { get; set; } // Powiat
    public string Gmina { get; set; } // Gmina
    public string Kraj { get; set; } // Kraj (PL)
    public string Kod { get; set; } // Kod pocztowy
    public string Terc { get; set; } // TERC kod
    public string Simc { get; set; } // SIMC kod
    public string Ulic { get; set; } // ULIC kod (opcjonalny)
    public string OpisNietypowegoMiejsca { get; set; } // Dodatkowy opis nietypowego miejsca (opcjonalny)
}