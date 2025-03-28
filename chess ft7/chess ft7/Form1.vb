Public Class Form1
    Private board(7, 7) As String
    Private pieceLabels As New Dictionary(Of Label, (Integer, Integer))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup default pos
        Dim blackPieces As String() = {"Rk", "Kn", "Bp", "Qn", "Kg", "Bp", "Kn", "Rk"}
        Dim whitePieces As String() = {"Rk", "Kn", "Bp", "Qn", "Kg", "Bp", "Kn", "Rk"}

        For col As Integer = 0 To 7
            board(0, col) = blackPieces(col) ' Black major pieces
            board(1, col) = "Pn" ' Black pawns
            board(6, col) = "Pn" ' White pawns
            board(7, col) = whitePieces(col) ' White major pieces
        Next

        ' Draw pieces
        DrawPieces()
    End Sub

    Private Sub DrawPieces()
        For row As Integer = 0 To 7
            For col As Integer = 0 To 7
                If board(row, col) <> "" Then
                    Dim pieceLabel As New Label With {
                        .Text = board(row, col),
                        .ForeColor = If(row < 2, Color.White, Color.Black), ' Black/White text
                        .BackColor = Color.Transparent,
                        .Font = New Font("Arial", 16, FontStyle.Bold),
                        .AutoSize = False,
                        .Size = New Size(50, 50),
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .Left = col * 50,
                        .Top = row * 50
                    }

                    AddHandler pieceLabel.Click, AddressOf Piece_Clicked
                    pieceLabels(pieceLabel) = (row, col)
                    boardImage.Controls.Add(pieceLabel)
                End If
            Next
        Next
    End Sub

    Private Sub Piece_Clicked(sender As Object, e As EventArgs)
        Dim clickedPiece As Label = CType(sender, Label)

        ' Toggle selection
        clickedPiece.BackColor = If(clickedPiece.BackColor = Color.Transparent, Color.LightGray, Color.Transparent)
    End Sub

End Class
