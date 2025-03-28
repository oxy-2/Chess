Public Class Form1
    Private chessBoard As TableLayoutPanel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' make layout
        chessBoard = New TableLayoutPanel
        chessBoard.Dock = DockStyle.Fill
        chessBoard.RowCount = 8
        chessBoard.ColumnCount = 8
        chessBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
        Me.Controls.Add(chessBoard)

        ' set size
        For i As Integer = 0 To 7
            chessBoard.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5))
            chessBoard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5))
        Next

        ' call to AddPeices
        AddPiecesToBoard()


        ' add panels
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7

                ' create panel
                Dim square As New Panel
                square.Dock = DockStyle.Fill

                ' colors
                If (i + j) Mod 2 = 0 Then
                    square.BackColor = Color.White
                Else
                    square.BackColor = Color.Black
                End If

                ' add panels to table at pos (i, j)
                chessBoard.Controls.Add(square, j, i)

            Next
        Next

    End Sub

    Private Sub AddPiecesToBoard()

        ' row 1 blk
        Dim blackPieces As String() = {"Rk", "Kn", "Bp", "Qn", "Kg", "Bp", "Kn", "Rk"}
        ' row 2 blk
        Dim blackPawns As String() = {"Pn", "Pn", "Pn", "Pn", "Pn", "Pn", "Pn", "Pn"}


        ' row 2 wht
        Dim whitePawns As String() = {"Pn", "Pn", "Pn", "Pn", "Pn", "Pn", "Pn", "Pn"}
        ' row 1 wht
        Dim whitePieces As String() = {"Rk", "Kn", "Bp", "Qn", "Kg", "Bp", "Kn", "Rk"}

        ' add blk pieces
        For i As Integer = 0 To 7

            ' row 0
            AddPieceToBoard(blackPieces(i), i, 0, Color.Black)

            ' row 1
            AddPieceToBoard(blackPawns(i), i, 1, Color.Black)

            ' row 6
            AddPieceToBoard(whitePawns(i), i, 6, Color.White)

            ' row 7
            AddPieceToBoard(whitePieces(i), i, 7, Color.White)


        Next
    End Sub

    Private Sub AddPieceToBoard(pieceText As String, col As Integer, row As Integer, textColor As Color)

        ' meow meow meow, meow ... meowwww ;(
        Dim pieceLabel As New Label()
        pieceLabel.Text = pieceText
        pieceLabel.ForeColor = textColor
        pieceLabel.TextAlign = ContentAlignment.MiddleCenter
        pieceLabel.Dock = DockStyle.Fill
        pieceLabel.BackColor = Color.Gray
        pieceLabel.Font = New Font("Arial", 16, FontStyle.Bold)


        ' add piece to given pos
        chessBoard.Controls.Add(pieceLabel, col, row)

    End Sub

End Class
