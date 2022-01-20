Imports System
Imports DateTime

Module Program
    Sub Main(args As String())
        task1b()
    End Sub

    sub task1Arrays()
        DIM maxMembers = 99
        DIM memberCount = 0
        DIM MemberFirstname(0 to maxMembers) AS STRING
        DIM MemberLastname(0 to maxMembers) AS STRING
        DIM VolunteerOptions() = {"Not Volunteer", "Pier Entrance Gate", "Gift Shop", "Painting and Decorating"}
        DIM VolunteerStatus(0 to maxMembers) AS INTEGER
        DIM DateJoined(0 to maxMembers) AS DATETIME
        DIM MemberFee(0 to maxMembers) AS BOOLEAN

    end sub

    sub task1a()
        DIM strDateFormat = "dd-MMM-yyyy"
        DIM dateValue as DATETIME

        DO 'REPEAT
            console.write("Enter a date (DD-MMM-YYYY): ")
            DIM Temp = console.readline()
            IF not isDate(Temp) THEN
                Temp = "01-JAN-1900"
                console.writeline("Error: Invalid Date")
            END IF
            dateValue = CDate(Temp)
        LOOP UNTIL (dateValue > CDate("01-JAN-2020") AND dateValue <= Now())
        Console.WriteLine("You entered: " & dateValue.ToString(strDateFormat))
        Console.Writeline("Expires: " & (dateValue.addyears(1)).ToString(strDateFormat))
    end sub

    sub task1b()
        DIM maxArr = 2
        DIM strDateFormat = "dd-MMM-yyyy"
        DIM dateArray(0 to maxArr) As DateTime

        FOR i = 0 TO maxArr
            DO 'REPEAT
                console.write("Enter a date (DD-MMM-YYYY): ")
                DIM Temp = console.readline()
                IF not isDate(Temp) THEN
                    Temp = "01-JAN-1900"
                    console.writeline("Error: Invalid Date")
                END IF
                dateArray(i) = CDate(Temp)
            LOOP UNTIL (dateArray(i) > CDate("01-JAN-2020") AND dateArray(i) <= Now())
            Console.WriteLine("You entered: " & dateArray(i).ToString("dd-MMM-yyyy"))
        NEXT i
        FOR i = 0 TO maxArr
            Console.Write("Date " & cstr(i) & " is: " & dateArray(i).ToString(strDateFormat))
            IF dateArray(i).addyears(1) < Now() THEN
                console.WriteLine(" Expired")
            ELSE
                console.WriteLine(" Valid")
            END IF
        NEXT i

    end sub

    sub oldTask()
        Dim strDateFormat = "dd-MMM-yyyy"
        Dim dt(0 to 2) As DateTime


        for i = 0 to 2
            Dim isValid = False
            While(Not isValid)
                Console.Write("Please enter a date (dd/mm/yyyy): ")
                Dim input = Console.ReadLine()
                'isValid = Date.TryParseExact(input, strDateFormat, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dt)
                isValid = DateTime.TryParse(input, dt(i))
            End While
        next i

    end sub 



End Module
