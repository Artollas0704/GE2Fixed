Imports System.Console
Module Module1
    Dim selector As Integer
    Dim resposta As Integer
    Dim resposta2 As Integer
    Dim contador As Integer
    Dim contador2 As Integer
    Dim user1 As String
    Dim user2 As String
    Dim cor As New Random
    Dim cor2 As Integer
    Dim random As New Random
    Dim randomselect As Integer



    Sub Main()
        Console.ForegroundColor = ConsoleColor.Magenta
        WriteLine(Space(75) & "***** GAME *****")
        WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        WriteLine("User 1, Choose your name.")
        Console.ForegroundColor = ConsoleColor.Cyan
        user1 = ReadLine()
        WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        WriteLine("User 2, Choose your name.")
        Console.ForegroundColor = ConsoleColor.Cyan
        user2 = ReadLine()


        Console.ForegroundColor = ConsoleColor.Magenta
        WriteLine(Space(72) & "CHOOSE THE QUIZ'S THEME")

        Console.ForegroundColor = ConsoleColor.DarkYellow
        WriteLine("1 --- GENERAL CULTURE")
        WriteLine("2 --- SPORTS")
        WriteLine("3 --- TECHNOLOGY")
        WriteLine()
        WriteLine("Choose your theme: ")
        selector = ReadLine()
        WriteLine()





        Do While contador < 2 Or contador2 < 2


            randomselect = random.Next(1, 6)

            
            Select Case selector



                Case 1
                    '1 pergunta
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine("RULES:")
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Cyan
                    WriteLine("Answer the following questions. For each correct answer you get 1 point, the first player to reach 2 points wins.")



                    If randomselect = 1 Then



                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Wich country has the largest population?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Russia")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Portugal")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- India")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- China")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 4 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 4 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")



                            WriteLine()


                            '2 pergunta
                        ElseIf randomselect = 2 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who was the first man to step on the moon?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Yuri Gagarin")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Neil Armstrong")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Buzz Aldrin")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- James Irwin")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1


                            Else
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")

                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")


                            WriteLine()
                            '3 pergunta
                        ElseIf randomselect = 3 Then

                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who wrote the Art of War?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Sun Tzu")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Mao Tsé Tung")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Gandhi")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Confúcio")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If


                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")



                            WriteLine()
                            '4 pergunta
                        ElseIf randomselect = 4 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who is known for this sentence? : I think, therefore I exist. ")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Descartes")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Galileu Galilei")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Sócrates")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Plato")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                            WriteLine()

                            '5 pergunta'
                        ElseIf randomselect = 5 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who was the first Portuguese King?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- D.João I")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- D. Afonso Henriques")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- D. Sebastião")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- D. Duarte I")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")
                        End If
                    ' Fim do primeiro tema '

                    'Segundo tema'
                    Case 2

                        'Primeira Pergunta do segundo tema'
                        Console.ForegroundColor = ConsoleColor.Magenta
                        WriteLine("RULES:")
                        WriteLine()
                        Console.ForegroundColor = ConsoleColor.Cyan
                        WriteLine("Answer the following questions. For each correct answer you get 1 point, the first player to reach 2 points wins.")
                        WriteLine()
                        If randomselect = 1 Then


                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Wich brand is used in official basketball games?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Nike")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Adidas")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Spalding")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Wilson")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")



                            WriteLine()
                            'Segunda pergunta'
                        ElseIf randomselect = 2 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Wich is the most played sports in the world?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Basketball")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- American Football")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Football")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Golf")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")


                            WriteLine()

                            '3a Pergunta'
                        ElseIf randomselect = 3 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who holds the record for most goals in football?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Cristiano Ronaldo")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Josef Bican")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Ferenc Puskás")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Lionel Messi")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")


                            WriteLine()

                            'quarta pergunta'
                        ElseIf randomselect = 4 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who has the most gold medals in the swimming category?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Jenny Thompson")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Mark Spitz")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Alexander Popov")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Michael Phelps")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 4 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 4 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")


                            WriteLine()
                            'Quinta Pergunta'
                        ElseIf randomselect = 5 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who holds the record for the most nba titles?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Bill Russel")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Scottie Pippen")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Michael Jordan")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Lebron James")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                        End If
                    ' Fim do Segundo tema'

                    'Inicio do terceiro tema'
                    Case 3

                        Console.ForegroundColor = ConsoleColor.Magenta
                        WriteLine("RULES:")
                        WriteLine()
                        Console.ForegroundColor = ConsoleColor.Cyan
                        WriteLine("Answer the following questions. For each correct answer you get 1 point, the first player to reach 2 points wins.")
                        WriteLine()
                        If randomselect = 1 Then


                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Wich operative system has the most market share?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Android")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Windows")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- iOS")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- OS X")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")



                            WriteLine()
                            'segunda pergunta'
                        ElseIf randomselect = 2 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("What was the first programming language?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Visual Basic")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- C++")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Plankalkül")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- JavaScript")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")



                            WriteLine()
                            'terceira pergunta'
                        ElseIf randomselect = 3 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Who was the world's first hacker")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- Anonymous")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- Kevin Mitnick")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- Adrian Lamo")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- Albert Gonzalez")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")


                            WriteLine()
                            'quarta pergunta'
                        ElseIf randomselect = 4 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("Wich is the most visited website?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- google.com")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- youtube.com")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- facebook.com")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- wikipedia.org")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 1 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")


                            WriteLine()

                            'Quinta pergunta'
                        ElseIf randomselect = 5 Then
                            Console.ForegroundColor = ConsoleColor.DarkYellow
                            WriteLine("In wich year was Microsoft founded?")
                            WriteLine()
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("1 --- 1973")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("2 --- 1974")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("3 --- 1975")
                            System.Threading.Thread.Sleep(1500)
                            WriteLine("4 --- 1976")
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user1 & " choose your answer.")
                            resposta = ReadLine()
                            WriteLine()
                            System.Threading.Thread.Sleep(1000)
                            WriteLine(user2 & " choose your answer.")
                            resposta2 = ReadLine()
                            WriteLine()

                            If resposta = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user1 & " chose the correct answer.")
                                contador += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user1 & " Failed, better luck next time")
                            End If

                            If resposta2 = 3 Then
                                Console.ForegroundColor = ConsoleColor.Green
                                WriteLine(user2 & " chose the correct answer.")
                                contador2 += 1

                            Else Console.ForegroundColor = ConsoleColor.DarkRed
                                WriteLine("Unfortunately " & user2 & " Failed, better luck next time")
                            End If
                            If contador = 2 Or contador2 = 2 Then
                                Console.ForegroundColor = ConsoleColor.Magenta
                                WriteLine(Space(90) & user1 & " has " & contador & " Points")
                                WriteLine(Space(90) & user2 & " has " & contador2 & " Points")

                                Exit Do
                            End If
                            WriteLine()
                            Console.ForegroundColor = ConsoleColor.Magenta
                            WriteLine(Space(90) & user1 & " has " & contador & " Points")
                            WriteLine(Space(90) & user2 & " has " & contador2 & " Points")


                        End If



                End Select
            Loop



            Do
            cor2 = cor.Next(1, 4)
            If cor2 = 1 Then
                Console.ForegroundColor = ConsoleColor.DarkRed
            ElseIf cor2 = 2 Then
                Console.ForegroundColor = ConsoleColor.Green
            ElseIf cor2 = 3 Then
                Console.ForegroundColor = ConsoleColor.Cyan


            End If

            If contador = contador2 Then
                For i = 1 To 20
                    WriteLine()
                Next
                WriteLine(Space(90) & "******************************************")
                WriteLine(Space(95) & "Both " & user1 & " and " & user2 & " ended up tied.")
                WriteLine(Space(90) & "******************************************")
            ElseIf contador > contador2 Then
                For i = 1 To 20
                    WriteLine()
                Next
                WriteLine(Space(90) & "******************************************")
                WriteLine(Space(100) & user1 & " Has won the game. ")
                WriteLine(Space(90) & "******************************************")
                    ElseIf contador < contador2 Then
                For i = 1 To 20
                    WriteLine()
                Next
                WriteLine(Space(90) & "******************************************")
                WriteLine(Space(100) & user2 & " Has won the game.")
                WriteLine(Space(90) & "******************************************")

            End If

            System.Threading.Thread.Sleep(250)
            Clear()

        Loop
        ReadLine()

    End Sub

End Module
