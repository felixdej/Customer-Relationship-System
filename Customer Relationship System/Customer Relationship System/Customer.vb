Public Class Customer

    Private cfirstName As String
    Private cmiddleName As String
    Private clastName As String
    Private cphoneNumber As Integer
    Private cemail As String

    Sub New(ByVal f As String, ByVal m As String, ByVal l As String, ByVal p As Integer, ByVal e As String)
        cfirstName = f
        cmiddleName = m
        clastName = l
        cphoneNumber = p
        cemail = e
    End Sub

    Public Property FirstName() As String
        Get
            Return cfirstName
        End Get
        Set(value As String)
            cfirstName = value
        End Set
    End Property

    Public Property MiddleName() As String
        Get
            Return cmiddleName
        End Get
        Set(value As String)
            cmiddleName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return clastName
        End Get
        Set(value As String)
            clastName = value
        End Set
    End Property

    Public Property PhoneName() As Integer
        Get
            Return cphoneNumber
        End Get
        Set(value As Integer)
            cphoneNumber = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return cemail
        End Get
        Set(value As String)
            cemail = value
        End Set
    End Property
End Class
