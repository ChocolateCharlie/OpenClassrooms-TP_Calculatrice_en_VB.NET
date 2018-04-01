Module Module1

    Sub Main()
        ' Déclaration des variables
        ' Variables du programme
        Dim Continuer As Boolean = True     ' False fait cesser la boucle du programme
        Dim EntreeUtilisateur As String     ' toutes les entrées utilisateur doivent être faites via cette variable pour vérification de leur validité
        ' Variables propres à la calculatrice
        Dim Operation As String
        Dim Nombre1 As Double
        Dim Nombre2 As Double

        ' Présentation de la calculatrice
        Console.WriteLine("--- TP : Calculatrice ---")

        ' Boucle du programme
        While Continuer
            ' Sélection de l'opération à effectuer
            Operation = ""      ' Refresh Operation
            Do
                Console.WriteLine("Veuillez choisir l'opération à effectuer :")
                EntreeUtilisateur = Console.ReadLine()
                Select Case EntreeUtilisateur
                    Case "+", "sum", "addition"
                        Operation = "+"
                    Case "-", "subtraction", "soustraction"
                        Operation = "-"
                    Case "*", "multiplication", "x"
                        Operation = "*"
                    Case "/", "division"
                        Operation = "/"
                    Case "%", "modulo", "reste"
                        Operation = "%"
                End Select
            Loop Until Operation <> Nothing

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

            ' Effectuer le calcul et en afficher le résultat (en fonction de l'opération demandée)
            Select Case Operation
                ' Addition
                Case "+"
                    Console.WriteLine(Nombre1 & " + " & Nombre2 & " = " & Nombre1 + Nombre2)
                ' Soustraction
                Case "-"
                    Console.WriteLine(Nombre1 & " - " & Nombre2 & " = " & Nombre1 - Nombre2)
                ' Multiplication
                Case "*"
                    Console.WriteLine(Nombre1 & " x " & Nombre2 & " = " & Nombre1 * Nombre2)
                ' Division
                Case "/"
                    Console.WriteLine(Nombre1 & " / " & Nombre2 & " = " & Nombre1 / Nombre2)
                ' Modulo
                Case "%"
                    Console.WriteLine(Nombre1 & " % " & Nombre2 & " = " & Nombre1 Mod Nombre2)
            End Select
            Console.ReadLine()      ' Pause factice

            ' Demander la permission de fermer le programme
            ' sinon effectuer une nouvelle opération (nouveau tour de boucle)
            ' NB : Une saisie invalide a pour effet de fermer le programme.
            Continuer = False
            Console.WriteLine("Souhaitez-vous effectuer une nouvelle opération ?")
            EntreeUtilisateur = Console.ReadLine()
            If EntreeUtilisateur = "Oui" Or EntreeUtilisateur = "oui" Or EntreeUtilisateur = "O" Or EntreeUtilisateur = "o" Or EntreeUtilisateur = "Yes" Or EntreeUtilisateur = "yes" Or EntreeUtilisateur = "Y" Or EntreeUtilisateur = "y" Then
                Continuer = True
            End If
        End While

    End Sub

End Module