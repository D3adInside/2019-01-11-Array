Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arrTest(3, 2) As Integer
        Dim mSum As Integer
        Randomize()
        For i = 0 To 3 Step 1
            For j = 0 To 2 Step 1
                arrTest(i, j) = Int(Rnd() * 9 + 1)
                mSum = mSum + arrTest(i, j)
                MsgBox(arrTest(i, j))
            Next

        Next
            MsgBox(mSum)


    End Sub
End Class
