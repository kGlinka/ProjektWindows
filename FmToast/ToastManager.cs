public static class ToastManager
{
    private static readonly int toastHeight = 80; // Wysokość powiadomienia
    private static readonly int maxToasts = 5; // Maksymalna liczba widocznych powiadomień
    private static readonly int toastSpacing = -20; // Odstęp między powiadomieniami

    private static bool[] positions = new bool[maxToasts]; // Tablica pozycji powiadomień (true = zajęta, false = wolna)

    private static object lockObject = new object(); // Obiekt do synchronizacji dostępu

    // Metoda do przydzielania dostępnej pozycji
    public static int GetNextToastOffset()
    {
        lock (lockObject)
        {
            for (int i = 0; i < maxToasts; i++)
            {
                if (!positions[i]) // Jeżeli pozycja jest wolna
                {
                    positions[i] = true; // Zajmujemy pozycję
                    return i * (toastHeight + toastSpacing); // Zwracamy offset tej pozycji
                }
            }
            return -1; // Brak dostępnych pozycji
        }
    }

    // Zwolnienie pozycji
    public static void ReleaseToastOffset(int offset)
    {
        int index = offset / (toastHeight + toastSpacing);
        if (index >= 0 && index < maxToasts)
        {
            lock (lockObject)
            {
                positions[index] = false; // Zwalniamy pozycję
            }
        }
    }
}
