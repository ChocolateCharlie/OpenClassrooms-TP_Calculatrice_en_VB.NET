Module Module1

    Sub Main()
        ' Déclaration des variables
        Dim EntreeUtilisateur As String
        Dim Nombre1 As Double
        Dim Nombre2 As Double

        ' Saisie du premier nombre
        Do
            Console.WriteLine("Veuillez saisir le premier nombre :")
            EntreeUtilisateur = Console.ReadLine()
        Loop Until IsNumeric(EntreeUtilisateur)

        Nombre1 = EntreeUtilisateur

        ' Saisie du second nombre
        Do
            Console.WriteLine("Veuillez saisir le second nombre :")
            EntreeUtilisateur = Console.ReadLine()
        Loop Until IsNumeric(EntreeUtilisateur)

        Nombre2 = EntreeUtilisateur

        ' Affichage du résultat
        Console.WriteLine(Nombre1 & " + " & Nombre2 & " = " & Nombre1 + Nombre2)
        Console.ReadLine()

    End Sub

End Module
