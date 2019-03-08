Public Class Form1
    '
    '
    ' (  )   /\   _                  (     
    '\ |  (  \ ( \.(                  )                      _____
    '\  \ \  `  `   ) \              (  ___                 / _   \
    '(_`    \+   . x  ( .\            \/   \____-----------/ (o)   \_
    '- .-               \+  ;         (  O                           \____
    '  Alexander Massin       )        \_____________  `              \  /
    '(__    11a      +- .( -'.- <. - _   VVVVVVV VV V\                 \/
    '(_____            ._._: <_ - <- _ (--  _AAAAAAA__A_/                  |
    ' .    /./.+-  . .- /  +--  - .     \______________//_              \_______
    ' (__ ' /x  / x _/ (                                  \___'          \     /
    ' , x / ( '  . / .  /                                     |           \   /
    ' /  /  _/ /    +                                        /              \/
    '   (__/                                              /                  \
    '
    '
    '
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit() 'This is how the user can exit the game'
    End Sub

    Private Sub btnPhantom_Click(sender As System.Object, e As System.EventArgs) Handles btnPhantom.Click
        btnPhantom.Enabled = False
        btnPhantom.Visible = False
        If btnZeus.Enabled = False Then          'Some patterns to finish quick include: C+G+A+I+E OR C+I+G+A+E OR E+C+A+I+G OR B+F+H+D+C+A+I+G+E+B+D+F+HN
            btnZeus.Enabled = True               '    | A | B | C |          
            btnZeus.Visible = True               '    | D | E | F |
        Else                                     '    | G | H | I |
            btnZeus.Enabled = False              'This whole thing is basically saying if the box is enabled, disable it and if its disabled, enable it.
            btnZeus.Visible = False              'Very tedious
        End If                                   'This goes on for the next 8 buttons
        If btnNecro.Enabled = False Then
            btnNecro.Enabled = True
            btnNecro.Visible = True
        Else
            btnNecro.Enabled = False
            btnNecro.Visible = False
        End If

    End Sub

    Private Sub btnAxe_Click(sender As System.Object, e As System.EventArgs) Handles btnAxe.Click
        btnAxe.Enabled = False
        btnAxe.Visible = False
        If btnZeus.Enabled = False Then
            btnZeus.Enabled = True
            btnZeus.Visible = True
        Else
            btnZeus.Enabled = False                   'Every box only disables and enables the other boxes that are touching it
            btnZeus.Visible = False
        End If
        If btnOgre.Enabled = False Then
            btnOgre.Enabled = True
            btnOgre.Visible = True
        Else
            btnOgre.Enabled = False
            btnOgre.Visible = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Application.Restart()            'This is how the user restarts the program by clicking the reset button
    End Sub

    Private Sub btnZeus_Click(sender As System.Object, e As System.EventArgs) Handles btnZeus.Click
        btnZeus.Enabled = False
        btnZeus.Visible = False
        If btnPhantom.Enabled = False Then
            btnPhantom.Enabled = True
            btnPhantom.Visible = True
        Else
            btnPhantom.Enabled = False
            btnPhantom.Visible = False
        End If
        If btnAxe.Enabled = False Then
            btnAxe.Enabled = True
            btnAxe.Visible = True
        Else
            btnAxe.Enabled = False
            btnAxe.Visible = False
        End If
        If btnClockwork.Enabled = False Then
            btnClockwork.Enabled = True
            btnClockwork.Visible = True
        Else
            btnClockwork.Enabled = False
            btnClockwork.Visible = False
        End If
    End Sub

    Private Sub btnClockwork_Click(sender As System.Object, e As System.EventArgs) Handles btnClockwork.Click
        btnClockwork.Enabled = False
        btnClockwork.Visible = False
        If btnOgre.Enabled = False Then
            btnOgre.Enabled = True
            btnOgre.Visible = True
        Else
            btnOgre.Enabled = False
            btnOgre.Visible = False
        End If
        If btnZeus.Enabled = False Then                    'This is a bigger code than the other buttons because it touches more buttons
            btnZeus.Enabled = True
            btnZeus.Visible = True
        Else
            btnZeus.Enabled = False
            btnZeus.Visible = False
        End If
        If btnEarthshaker.Enabled = False Then
            btnEarthshaker.Enabled = True
            btnEarthshaker.Visible = True
        Else
            btnEarthshaker.Enabled = False
            btnEarthshaker.Visible = False
        End If
        If btnNecro.Enabled = False Then
            btnNecro.Enabled = True
            btnNecro.Visible = True
        Else
            btnNecro.Enabled = False
            btnNecro.Visible = False
        End If
    End Sub

    Private Sub btnNecro_Click(sender As System.Object, e As System.EventArgs) Handles btnNecro.Click
        btnNecro.Enabled = False
        btnNecro.Visible = False
        If btnClockwork.Enabled = False Then
            btnClockwork.Enabled = True
            btnClockwork.Visible = True
        Else
            btnClockwork.Enabled = False
            btnClockwork.Visible = False
        End If
        If btnPhantom.Enabled = False Then
            btnPhantom.Enabled = True
            btnPhantom.Visible = True
        Else
            btnPhantom.Enabled = False
            btnPhantom.Visible = False
        End If
        If btnDisruptor.Enabled = False Then
            btnDisruptor.Enabled = True
            btnDisruptor.Visible = True
        Else
            btnDisruptor.Enabled = False
            btnDisruptor.Visible = False
        End If
    End Sub

    Private Sub btnOgre_Click(sender As System.Object, e As System.EventArgs) Handles btnOgre.Click
        btnOgre.Enabled = False
        btnOgre.Visible = False
        If btnInvoker.Enabled = False Then
            btnInvoker.Enabled = True
            btnInvoker.Visible = True
        Else
            btnInvoker.Enabled = False
            btnInvoker.Visible = False
        End If
        If btnAxe.Enabled = False Then
            btnAxe.Enabled = True
            btnAxe.Visible = True
        Else
            btnAxe.Enabled = False
            btnAxe.Visible = False
        End If
        If btnClockwork.Enabled = False Then
            btnClockwork.Enabled = True
            btnClockwork.Visible = True
        Else
            btnClockwork.Enabled = False
            btnClockwork.Visible = False
        End If

    End Sub

    Private Sub btnEarthshaker_Click(sender As System.Object, e As System.EventArgs) Handles btnEarthshaker.Click
        btnEarthshaker.Enabled = False
        btnEarthshaker.Visible = False
        If btnClockwork.Enabled = False Then
            btnClockwork.Enabled = True
            btnClockwork.Visible = True
        Else
            btnClockwork.Enabled = False
            btnClockwork.Visible = False
        End If
        If btnInvoker.Enabled = False Then
            btnInvoker.Enabled = True
            btnInvoker.Visible = True
        Else
            btnInvoker.Enabled = False
            btnInvoker.Visible = False
        End If
        If btnDisruptor.Enabled = False Then
            btnDisruptor.Enabled = True
            btnDisruptor.Visible = True
        Else
            btnDisruptor.Enabled = False
            btnDisruptor.Visible = False
        End If
    End Sub

    Private Sub btnInvoker_Click(sender As System.Object, e As System.EventArgs) Handles btnInvoker.Click
        btnInvoker.Enabled = False
        btnInvoker.Visible = False
        If btnEarthshaker.Enabled = False Then
            btnEarthshaker.Enabled = True
            btnEarthshaker.Visible = True
        Else
            btnEarthshaker.Enabled = False
            btnEarthshaker.Visible = False
        End If
        If btnOgre.Enabled = False Then
            btnOgre.Enabled = True
            btnOgre.Visible = True
        Else
            btnOgre.Enabled = False
            btnOgre.Visible = False
        End If
    End Sub

    Private Sub btnDisruptor_Click(sender As System.Object, e As System.EventArgs) Handles btnDisruptor.Click
        btnDisruptor.Enabled = False
        btnDisruptor.Visible = False
        If btnNecro.Enabled = False Then
            btnNecro.Enabled = True
            btnNecro.Visible = True
        Else
            btnNecro.Enabled = False
            btnNecro.Visible = False
        End If
        If btnEarthshaker.Enabled = False Then
            btnEarthshaker.Enabled = True
            btnEarthshaker.Visible = True
        Else
            btnEarthshaker.Enabled = False
            btnEarthshaker.Visible = False
        End If
    End Sub
End Class
