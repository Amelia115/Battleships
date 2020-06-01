Imports System

Module Program
    Structure Twoblockship
        Dim blocks As Integer
        Dim Hitcheck1 As Boolean
        Dim Hitcheck2 As Boolean
        Dim sunk As String
    End Structure


    Structure Threeblockship
        Dim blocks As Integer
        Dim Hitcheck1 As Boolean
        Dim Hitcheck2 As Boolean
        Dim Hitcheck3 As Boolean
        Dim sunk As String
    End Structure

    Structure Fourblockship
        Dim blocks As Integer
        Dim Hitcheck1 As Boolean
        Dim Hitcheck2 As Boolean
        Dim Hitcheck3 As Boolean
        Dim Hitcheck4 As Boolean
        Dim sunk As String
    End Structure

    Structure Fiveblockship
        Dim blocks As Integer
        Dim Hitcheck1 As Boolean
        Dim Hitcheck2 As Boolean
        Dim Hitcheck3 As Boolean
        Dim Hitcheck4 As Boolean
        Dim Hitcheck5 As Boolean
        Dim sunk As String
    End Structure


    Sub Main()
        ' the Array that the board is on
        Dim board(10, 10) As String
        Dim shipcoords(5) As String
        ' defines the ships
        Dim Destroyer As Twoblockship
        Dim lightcruiser As Threeblockship
        'Dim submarine As Threeblockship
        'Dim heavycruiser As Fourblockship
        'Dim carrier As Fiveblockship
        ' defines the coordinates for the destroyer
        Dim UserXCords(5) As Integer
        Dim UserYCords(5) As Integer
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
            UserXCords(t) = Console.ReadLine
            UserYCords(t) = Console.ReadLine


            'Checks if the coordinates are on the board
            If UserXCords(t) > 10 Or UserYCords(t) > 10 Then
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
                            G = UserXCords(t) + 1
                            H = UserYCords(t)
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(UserXCords(t), UserYCords(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                        Case "up"
                            G = UserXCords(t) - 1
                            H = UserYCords(t)
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(UserXCords(t), UserYCords(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                        Case "right"
                            G = UserXCords(t)
                            H = UserYCords(t) + 1
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(UserXCords(t), UserYCords(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                        Case "left"
                            G = UserXCords(t)
                            H = UserYCords(t) - 1
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            board(UserXCords(t), UserYCords(t)) = Destroyer.blocks
                            board(G, H) = Destroyer.blocks
                    End Select
                Case 1
                    Select Case Answer(t)
                        Case "down"
                            P = UserXCords(t) + 2
                            G = UserXCords(t) + 1
                            H = UserYCords(t)
                            O = UserYCords(t)
                            If G > 10 Or H > 10 Then
                                Console.WriteLine("outside the board")
                                End
                            End If
                            For Y As Integer = 0 To 4
                                If P = UserXCords(Y) Or G = UserXCords(Y) Then
                                    Console.WriteLine("overlapping ships")
                                    End
                                End If
                            Next
                            board(G, H) = "LC"
                            board(P, O) = "LC"
                        Case "up"
                            P = UserXCords(t) - 2
                            G = UserXCords(t) - 1
                            H = UserYCords(t)
                            O = UserYCords(t)
                            For Y As Integer = 0 To 4
                                If P = UserXCords(Y) Or G = UserXCords(Y) Then
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
                            P = UserXCords(t)
                            G = UserXCords(t)
                            H = UserYCords(t) + 1
                            O = UserYCords(t) + 2

                            For Y As Integer = 0 To 4
                                If H = UserYCords(Y) Or O = UserYCords(Y) Then
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
                            P = UserXCords(t)
                            G = UserXCords(t)
                            H = UserYCords(t) - 1
                            O = UserYCords(t) - 2

                            For Y As Integer = 0 To 4
                                If H = UserYCords(Y) Or O = UserYCords(Y) Then
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

        Attack(board, Destroyer, lightcruiser)

        For i As Integer = 0 To 10

            For f As Integer = 0 To 10

                If board(i, f) <> "" Then

                    If Destroyer.Hitcheck1 = True Then

                        Console.Write("Hit")

                    ElseIf lightcruiser.Hitcheck1 = True Then

                        Console.Write("Hit")

                    ElseIf Destroyer.Hitcheck1 Then

                        Console.Write("D")

                    ElseIf lightcruiser.Hitcheck1 Then

                        Console.Write("LC")
                    Else

                        Console.Write(board(i, f))

                    End If

                Else

                    Console.Write(",")

                End If

            Next

            Console.WriteLine("|")

        Next


    End Sub

    Sub Attack(Board As String(,), Destroyer As Twoblockship, lightcruiser As Threeblockship)
        Dim attackcoordY As String
        Dim attackcoordX As String
        Console.WriteLine("write your first coordinate")
        attackcoordX = Console.ReadLine()
        Console.WriteLine("write your second coordinate")
        attackcoordY = Console.ReadLine()
        If Board(attackcoordX, attackcoordY) <> "" Then
            Select Case Board(attackcoordX, attackcoordY)
                Case 2
                    Destroyer.Hitcheck1 = True

                Case 3
                    lightcruiser.Hitcheck1 = True

            End Select
        End If


    End Sub

    Sub Hit()


    End Sub

End Module
