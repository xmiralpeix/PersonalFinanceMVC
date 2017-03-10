Public Class RoleViewModel

    Public Property Id As String
    Public Property Name As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal role As ApplicationRole)
        Id = role.Id
        Name = role.Name
    End Sub

End Class
