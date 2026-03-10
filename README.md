Portal pacjenta

Wymagania Funkcjonalne

1.1. Dodanie nowego pacjenta 

Opis: Rejestracja pacjenta w systemie przez pracownika (np. rejestratorkę)

Szczegóły:
  -System powinien umożliwiać wprowadzenie danych osobowych: imię, nazwisko, PESEL (klucz unikalny), data urodzenia, adres zamieszkania oraz numer telefonu. 
  -System musi sprawdzać, czy pacjent o danym numerze PESEL już istnieje w bazie danych, aby uniknąć powtórzeń.

2.2. Historia wizyt pacjenta 

Opis:
Przeglądanie chronologicznego zestawienia wszystkich odbytych i zaplanowanych wizyt. 

Szczegóły: 
  -Każdy rekord w historii powinien zawierać: datę i godzinę wizyty, imię i nazwisko lekarza, cel wizyty, rozpoznanie (opcjonalnie) oraz zalecenia po wizycie.
  -Możliwość filtrowania historii według zakresu dat lub nazwiska lekarza.

1.3. Spis lekarzy

Opis:
Spis lekarzy oraz ich godziny i miejsca przyjmowania 

Szczegóły:
  -Lista zawierająca dane lekarzy: imię, nazwisko, specjalizacja oraz numer gabinetu. 
  -Funkcja wyszukiwania lekarza po specjalizacji lub nazwisku.

1.4. Godziny przyjmowania przez lekarzy

Opis:
Informacje o grafiku przyjmowania przez danych lekarzy 

Szczegóły: 
  -System wyświetla harmonogram tygodniowy każdego lekarza oraz dostępne terminy wizyt 
  -Integracja z systemem rezerwacji – godziny muszą być powiązane z dostępnymi terminami wizyt, aby uniknąć nakładania się terminów.

1.5. Tworzenie konta pacjenta 
Opis: Proces samodzielnej rejestracji pacjenta w serwisie internetowym. 
Szczegóły:
  -Użytkownik podaje adres e-mail (login) oraz hasło. Konto musi zostać powiązane z danymi pacjenta w bazie ( przez weryfikację numeru PESEL).

Wymagania Niefunkcjonalne

2.1. Baza danych SQLite System musi korzystać z lekkiej, plikowej bazy danych SQLite.

2.2. Szyfrowanie haseł Hasła użytkowników nie mogą być przechowywane w formie jawnego tekstu .Dzięki temu nawet w przypadku wycieku bazy danych, hasła pozostają nieczytelne dla osób niepowołanych.

2.3. Responsywność
Interfejs użytkownika (UI) musi automatycznie dostosowywać się do rozdzielczości ekranu.

2.4. Walidacja danych wejściowych Natychmiastowa informacja dla użytkownika (np. podświetlenie czerwonym kolorem zbyt krótkiego hasła lub błędnego formatu e-mail). 
Walidacja po stronie serwera:  blokowanie prób wstrzyknięcia kodu (SQL Injection, XSS) oraz sprawdzanie poprawności logicznej danych (np. czy PESEL ma 11 cyfr) przed zapisem w bazie.
