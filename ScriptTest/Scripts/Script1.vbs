Dim x
Dim y
dim word, doc, objSelection

call app.AddLog(app.MainForm.Text)
app.MainForm.Text = "Hello " & env.UserName & " from VBS!"

x = 1
y = 2
call app.AddLog(x+y)
app.MainForm.WindowState = clr.System.Windows.Forms.FormWindowState.Maximized

set word = host.newComObj("Word.Application")
word.Visible = true
set doc = word.Documents.Add

Set objSelection = word.Selection
objSelection.Font.Name = "Arial"
objSelection.Font.Size = 18
objSelection.TypeText app.MainForm.Text
objSelection.TypeParagraph()

objSelection.Font.Size = 14
objSelection.TypeText "" & Date()
objSelection.TypeParagraph()

doc.Saved = true
set word = Nothing