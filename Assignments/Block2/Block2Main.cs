using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

static class PasswordManager {
    private static SHA256 sha256 = SHA256.Create();
    private static HashSet<string> passwords = [];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GetHash(string input) =>
        Convert.ToBase64String(sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input)));

    public static void AddPassword(string input) =>
        passwords.Add(GetHash(input));
    public static bool Contains(string password) =>
        passwords.Contains(GetHash(password));
    public static void Remove(string input) =>
        passwords.Remove(GetHash(input));

    public static void Main() {
        // AddPassword("password"); // Sterotypical Weak Password
        // AddPassword("password123"); // Sterotypical Weak Password
        // AddPassword("pass1word"); // Sorta Strong
        // AddPassword("drowssap"); // 'password' Reversed
        // AddPassword("ilovechicken"); // First thing that came to mind
        // AddPassword("copper123"); // My dog's name followed by some numbers

        string? current;
        while((current = Console.ReadLine()) is not null && current.Length > 0) {
            AddPassword(current);
        }

        Stopwatch sw = new();
        sw.Start();
        foreach(var _try in File.ReadLines("Assignments/Block2/rockyou.txt")) {
            if(Contains(_try)) {
                Console.WriteLine($"Password: {_try} was discovered successfully in {sw.Elapsed.Milliseconds / 1000D} Seconds!");
            }
        }
        Console.WriteLine($"Took {sw.Elapsed.Milliseconds / 1000D} to check more than 14 million common passwords.");
    }
}