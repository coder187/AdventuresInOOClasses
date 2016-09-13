Public Class WebForm1
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Users As New List(Of SystemUser)()

        Users.Add(New SystemUser() With {.id = "biglongalphanumericstring_!%$345^", .first_name = "Jonathan", .link = "jkelly@ksd.ie", .locale = "IE", .username = "jkelly"})
        Users.Add(New SystemUser() With {.id = "biglongalphanumericstring_!%$678^", .first_name = "Mike", .link = "Mkelly@msn.com", .locale = "IE", .username = "mkelly"})
        Users.Add(New SystemUser() With {.id = "biglongalphanumericstring__^&*(1", .first_name = "Sponge", .link = "sbob@bikinibottom.co.bb", .locale = "bb", .username = "sbob109"})

        GV_users.DataSource = Users
        GV_users.DataBind()
        Response.Write("All Done")
    End Sub

End Class