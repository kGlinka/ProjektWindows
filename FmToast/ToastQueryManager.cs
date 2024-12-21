using ToastAlerts;

public static class ToastQueueManager
{
    // Kolejka przechowująca powiadomienia do wyświetlenia
    private static Queue<Tuple<string, string, string>> toastQueue = new Queue<Tuple<string, string, string>>();

    // Flaga do sprawdzania, czy powiadomienie jest wyświetlane
    private static bool isToastShowing = false;

    // Metoda dodająca powiadomienie do kolejki
    public static void AddToastToQueue(string type, string message, string controlName)
    {
        toastQueue.Enqueue(new Tuple<string, string, string>(type, message, controlName));
        // Jeśli aktualnie nic nie jest wyświetlane, zaczynamy przetwarzanie kolejki
        if (!isToastShowing)
        {
            ProcessQueue();
        }
    }

    // Metoda przetwarzająca kolejkę
    private static async void ProcessQueue()
    {
        isToastShowing = true;

        // Pętla sprawdzająca kolejkę
        while (toastQueue.Count > 0)
        {
            // Pobierz dane powiadomienia z kolejki
            var toastData = toastQueue.Dequeue();
            string type = toastData.Item1;
            string message = toastData.Item2;
            string controlName = toastData.Item3;
            // Sprawdź, czy jest dostępna pozycja na ekranie
            int toastOffset = ToastManager.GetNextToastOffset();
            if (toastOffset == -1)
            {
                // Jeśli brak dostępnych pozycji, poczekaj i spróbuj ponownie
                toastQueue.Enqueue(new Tuple<string, string, string>(type, message, controlName));
                await Task.Delay(500); // Czekaj 500ms przed ponowną próbą
                continue;
            }

            // Jeśli pozycja jest dostępna, wyświetl powiadomienie
            Fmtoast toast = new Fmtoast(type, message, controlName, toastOffset);
            toast.Show();
            await Task.Delay(50); // Czekaj chwilę zanim pojawi się następne powiadomienie
        }

        // Po zakończeniu przetwarzania kolejki, ustaw flagę na false
        isToastShowing = false;
    }

}
