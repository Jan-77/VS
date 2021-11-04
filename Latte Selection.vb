'Program Name: Latte Selection
'Developer: Jan Luis Telemaco Márquez
'Date: October 20, 2021
'Purpose: This application display two latte flavors (pumpkin spice and mocha).
'The user can select a latte falvor.


Public Class frmLatteSelection
	Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
		'This code is executed when user clicks the Pumpkin Spice button. It desplay the
		'the pumpkin picture, hides the mocha picture, and enables the  Select Latte button.

		picPumpkin.Visible = True
		picMocha.Visible = False
		btnSelect.Enabled = True

	End Sub
	Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
		'This code is executed when the user click the Select button. It disable the
		'Pumkin Spice button, and the Mocha button. It hides the
		'Instructions label, displays the Confirmation label, and enables the Exit Window button.
		btnPumpkin.Enabled = False
		btnSelect.Enabled = False
		lblIntructions.Visible = False
		lblconfirmation.Visible = True
		btnExit.Enabled = True

	End Sub

	Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
		'This code is executed when the user clicks the Mocha Button. Is disable the
		'mocha picture, hides the pumpkin picture, and enables the Select Button.

		picMocha.Visible = True
		picPumpkin.Visible = False
		btnSelect.Enabled = True

	End Sub
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		'This code is executed when the user clicks the Exit Window button.
		'It closes the window and terminate the program execution.

		Close()
	End Sub
End Class

