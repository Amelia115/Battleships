Imports System

Module Program
    Structure twoblockship
        Dim blocks As Integer
        Dim Hitcheck1 As String
        Dim Hitcheck2 As String
        Dim sunk As String
    End Structure


    Structure Threeblockship
        Dim blocks As Integer
        Dim Hitcheck1 As String
        Dim Hitcheck2 As String
        Dim Hitcheck3 As String
        Dim sunk As String
    End Structure

    Structure Fourblockship
        Dim blocks As Integer
        Dim Hitcheck1 As String
        Dim Hitcheck2 As String
        Dim Hitcheck3 As String
        Dim Hitcheck4 As String
        Dim sunk As String
    End Structure

    Structure Fiveblockship
        Dim blocks As Integer
        Dim Hitcheck1 As String
        Dim Hitcheck2 As String
        Dim Hitcheck3 As String
        Dim Hitcheck4 As String
        Dim Hitcheck5 As String
        Dim sunk As String
    End Structure


    Sub Main(args As String())
        ' the Array that the board is on
        Dim board(10, 10) As String
        Dim shipcoords(5) As Double
        ' defines the ships
        Dim Destroyer As twoblockship
        Dim lightcruiser As Threeblockship
        Dim submarine As Threeblockship
        Dim heavycruiser As Fourblockship
        Dim carrier As Fiveblockship
        ' defines the coordinates for the destroyer
        Dim A(5) As Integer
        Dim B(5) As Integer
        Dim G, H, P, O, t As Integer
        ' sets the position for the destroyer
        Dim Answer(5) As String
        Destroyer.blocks = 2
        lightcruiser.blocks = 3

        For t = 0 To 4
            Select Case t
                Case 0
                    ' asks the user where they want the destroyer to be
                    Console.WriteLine("where will your destroyer be")

                Case 1
                    ' asks the user where they want the Light criuser to be
                    Console.WriteLine("where will your light cruiser be")

                Case 2
                    ' asks the user where they want the submarine to be
                    Console.WriteLine("where will your submarine be")

                Case 3
                    ' asks the user where they want the Heavy cruiser to be
                    Console.WriteLine("where will your heavy cruiser be")

                Case 4
                    ' asks the user where they want the Carrier to be
                    Console.WriteLine("wherew will your carrier be")
            End Select
            'Gets the inputted coordinates
            A(t) = Console.ReadLine
            B(t) = Console.ReadLine


            'Checks if the coordinates are on the board
            If A(t) > 10 Or B(t) > 10 Then
                End
            End If
            'asks which direction it wants to be
            Console.WriteLine("will it going left, right up or down?")
            'gets which direction the user inputs
            Answer(t) = Console.ReadLine
            'changes it lowercase
            Answer(t) = Answer(t).ToLower
            Select Case t
                Case 0
                    Select Case Answer(t)
                        Case "down"
                            G = A(t) + 1
                            H = B(t)
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(A(t), B(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                            shipcoords(1) = "destroyer:" + A(t) + "," + B(t) + "," + G + "," + H
                        Case "up"
                            G = A(t) - 1
                            H = B(t)
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(A(t), B(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                            shipcoords(1) = "destroyer:" + A(t) + "," + B(t) + "," + G + "," + H
                        Case "right"
                            G = A(t)
                            H = B(t) + 1
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(A(t), B(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                            A(t) = Convert.ToString(A(t))
                            B(t) = Convert.ToString(B(t))
                            G = Convert.ToString(G)
                            H = Convert.ToString(H)

                            shipcoords(1) = A(t) + B(t) + G + H
                        Case "left"
                            G = A(t)
                            H = B(t) - 1
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(A(t), B(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                            shipcoords(1) = "destroyer:" + A(t) + "," + B(t) + "," + G + "," + H
                    End Select
                Case 1
                    Select Case Answer(t)
                        Case "down"
                            P = A(t) + 2
                            G = A(t) + 1
                            H = B(t)
                            O = B(t)
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            shipcoords(2) = "Light Cruiser:" + "X1:" + A(t) + ", Y1:" + B(t) + ", X2:" + G + ", Y2:" + H + ", X3:" + P + ", Y3" + O
                            For Y As Integer = 0 To 4
                                If P = A(Y) Or G = A(Y) Then
                                    Console.WriteLine("overlapping ships")
                                    End
                                End If
                            Next
                            board(G, H) = "LC"
                            board(P, O) = "LC"
                        Case "up"
                            P = A(t) - 2
                            G = A(t) - 1
                            H = B(t)
                            O = B(t)
                            shipcoords(2) = "Light Cruiser:" + "X1:" + A(t) + ", Y1:" + B(t) + ", X2:" + G + ", Y2:" + H + ", X3:" + P + ", Y3" + O
                            For Y As Integer = 0 To 4
                                If P = A(Y) Or G = A(Y) Then
                                    Console.WriteLine("overlapping ships")
                                    End
                                End If
                            Next
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(G, H) = lightcruiser.blocks
                            board(P, O) = lightcruiser.blocks
                        Case "right"
                            P = A(t)
                            G = A(t)
                            H = B(t) + 1
                            O = B(t) + 2
                            shipcoords(2) = "Light Cruiser:" + "X1:" + A(t) + ", Y1:" + B(t) + ", X2:" + G + ", Y2:" + H + ", X3:" + P + ", Y3" + O
                            For Y As Integer = 0 To 4
                                If H = B(Y) Or O = B(Y) Then
                                    Console.WriteLine("overlapping ships")
                                    End
                                End If
                            Next
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(G, H) = lightcruiser.blocks
                            board(P, O) = lightcruiser.blocks
                        Case "left"
                            P = A(t)
                            G = A(t)
                            H = B(t) - 1
                            O = B(t) - 2
                            shipcoords(2) = "Light Cruiser:" + "X1:" + A(t) + ", Y1:" + B(t) + ", X2:" + G + ", Y2:" + H + ", X3:" + P + ", Y3" + O
                            For Y As Integer = 0 To 4
                                If H = B(Y) Or O = B(Y) Then
                                    Console.WriteLine("overlapping ships")
                                    End
                                End If
                            Next
                            If G > 10 Or H > 10 Or H > 10 Or O > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(G, H) = lightcruiser.blocks
                            board(P, O) = lightcruiser.blocks
                    End Select
            End Select


        Next

        For i As Integer = 0 To 10
            For f As Integer = 0 To 10

                Attack(shipcoords, Destroyer, lightcruiser)
                If board(i, f) <> "" Then
                    If Destroyer.Hitcheck1 = True Then
                        Console.Write("Hit")
                    ElseIf lightcruiser.Hitcheck1 = True Then
                        Console.Write("Hit")
                    End If
                    Console.Write(board(i, f))
                Else
                    Console.Write(",")
                End If

            Next
            Console.WriteLine("|")
        Next
    End Sub

    Sub Attack(shipcoords As Double(), Destroyer As twoblockship, lightcruiser As Threeblockship)
        Dim attackcords1, attackcords2 As String
        Dim attackcheck As String
        Console.WriteLine("where will you attack")
        attackcords1 = Console.ReadLine
        attackcords2 = Console.ReadLine
        For i As Integer = 0 To 5
            If shipcoords(i).Contains(attackcords1) And shipcoords(i).Contains(attackcords2) Then
                Console.WriteLine("Hit")
                If shipcoords(i).Contains("destroyer") Then
                    Destroyer.Hitcheck1 = True
                ElseIf shipcoords(i).Contains("Light Cruiser") Then
                    lightcruiser.Hitcheck1 = True
                End If
            Else
                Console.WriteLine("miss")
            End If
        Next

    End Sub

    Sub hit()


    End Sub

End Module
