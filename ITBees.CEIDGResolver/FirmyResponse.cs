namespace ITBees.CEIDGResolver;

public class FirmyResponse
{
    public List<Firma> Firmy { get; set; } // Lista firm
    public int Count { get; set; } // Liczba firm
    public Links Links { get; set; } // Linki do paginacji
    public Properties Properties { get; set; } // Dodatkowe właściwości odpowiedzi
}