Imports System.Text.RegularExpressions

Module Validations

    Sub Fun_Only_Letters(strAllowKey As String, strLockKey As String, e As KeyPressEventArgs)

        '| IF : Comprobamos si una de las condiciones se cumplem.
        '|      * Not Char.IsLetter(e.KeyChar) - Permite letras mayúsculas y minúsculas.
        '|      * Not Char.IsControl(e.KeyChar) - Permite teclas de control por ejemplo Backspace.
        '|      * Not Allow_Key.Contains(e.KeyChar)) - Permite los caracteres que están almacenadas en la variable.
        '|      * Lock_Key.Contains(e.KeyChar)) - Bloquea los caracteres que están almacenadas en la variable.
        '| * Si la tecla no cumple NINGUNA de las condiciones anteriores la bloqueamos - e.Handled = True

        If (Not Char.IsLetter(e.KeyChar) AndAlso
            Not Char.IsControl(e.KeyChar) AndAlso
            Not strAllowKey.Contains(e.KeyChar)) OrElse
            strLockKey.Contains(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Sub Fun_Only_Numbers(textBox As TextBox, e As KeyPressEventArgs)

        '| IF : Comprobamos si una de las condiciones se cumplem.
        '|      * Not Char.IsDigit(e.KeyChar) - Permite dígitos.
        '|      * Not Char.IsControl(e.KeyChar) - Permite teclas de control por ejemplo Backspace.
        '|      IF : Comprobamos si es el punto decimal y cambiamos por la coma.
        '|          * e.Handled = False - Permite ingresar solo un punto.
        '| * Si la tecla no cumple NINGUNA de las condiciones anteriores la bloqueamos - e.Handled = True

        If Not Char.IsDigit(e.KeyChar) AndAlso
            Not Char.IsControl(e.KeyChar) Then

            If e.KeyChar = "."c AndAlso Not textBox.Text.Contains(",") Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Sub Fun_Only_Numbers(strAllowKey As String, e As KeyPressEventArgs)

        '| * Almacenamos en la variable Allow_Key los caracteres PERMITIDOS.
        '| IF : Comprobamos si una de las condiciones se cumplem.
        '|      * Not Char.IsDigit(e.KeyChar) - Permite dígitos.
        '|      * Not Char.IsControl(e.KeyChar) - Permite teclas de control _
        '|        _ por ejemplo Backspace.
        '|      * Not Allow_Key.Contains(e.KeyChar)) - Permite los caracteres _
        '|        _ que están almacenadas en la variable.
        '| * Si la tecla no cumple NINGUNA de las condiciones anteriores la _
        '|   _ bloqueamos - e.Handled = True.

        If Not Char.IsDigit(e.KeyChar) AndAlso
            Not Char.IsControl(e.KeyChar) AndAlso
            Not strAllowKey.Contains(e.KeyChar) Then

            e.Handled = True
        End If

    End Sub

    Sub Fun_Letters_And_Numbers(strAllowKey As String, e As KeyPressEventArgs)

        '| IF : Comprobamos si una de las condiciones se cumplem.
        '|      * Not Char.IsLetterOrDigit(e.KeyChar) - Si el carácter es una letra o un dígito, incluye los _
        '|        _ caracteres acentuados y la ñ, haciendo que la validación sea más robusta.
        '|      * Not Char.IsControl(e.KeyChar) - Permite teclas de control por ejemplo Backspace.
        '|      * Not Allow_Key.Contains(e.KeyChar)) - Permite los caracteres que están almacenadas en la variable.
        '| * Si la tecla no cumple NINGUNA de las condiciones anteriores la bloqueamos - e.Handled = True

        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso
            Not Char.IsControl(e.KeyChar) AndAlso
            Not strAllowKey.Contains(e.KeyChar) Then

            e.Handled = True
        End If

    End Sub

    Function Fun_IsValid_Email(eMail As String) As Boolean 'Public

        '| * Almacenamos en la variable strRegex un patrón de Regex estándar para validar _
        '|   _ correos electrónicos, cubre letras, números, guiones, puntos, guiones _
        '|   _ bajos, el signo de más y asegura la estructura parte_local@dominio.tld.
        '| * Regex.IsMatch comprueba si la cadena cumple con el patrón y devuelve si es _
        '|   _ verdadero o falso.

        Dim strRegex As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(eMail, strRegex)

    End Function

End Module
