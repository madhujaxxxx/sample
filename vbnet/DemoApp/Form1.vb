Public Class Form1
    Private Sub BtnClickMe_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        btnClickMe.Text = "Clicked"
        Me.BackColor = Color.GreenYellow
        MessageBox.Show("Hello World")
        txtResult.Select()

    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        MessageBox.Show("Open...")
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Close()
    End Sub

    Private Sub ctxGreen_Click(sender As Object, e As EventArgs) Handles ctxGreen.Click
        BackColor = Color.Green
    End Sub

    Private Sub ctxBlue_Click(sender As Object, e As EventArgs) Handles ctxBlue.Click
        BackColor = Color.Blue
    End Sub

    Private Sub ctxRed_Click(sender As Object, e As EventArgs) Handles ctxRed.Click
        BackColor = Color.Red
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Dim i As Integer
        Dim ItemList As New ArrayList()
        ItemList.Add("Item4")
        ItemList.Add("Item1")
        ItemList.Add("Item2")
        ItemList.Add("Item3")
        ItemList.Add("Item5")
        MsgBox("Show Items...")
        For i = 0 To ItemList.Count - 1
            MsgBox(ItemList.Item(i))
        Next
        'Insert an item
        ItemList.Insert(3, "Item6")
        MsgBox("Show Items...")
        For i = 0 To ItemList.Count - 1
            MsgBox(ItemList.Item(i))
        Next
        'Sort items
        ItemList.Sort()
        'Remove item by its value
        ItemList.Remove("Item2")
        MsgBox("Show Items...")
        For i = 0 To ItemList.Count - 1
            MsgBox(ItemList.Item(i))
        Next
        'Remove item by its key
        ItemList.RemoveAt(0)
        MsgBox("Show Items...")
        For i = 0 To ItemList.Count - 1
            MsgBox(ItemList.Item(i))
        Next
    End Sub

    Private Sub btnHashTable_Click(sender As Object, e As EventArgs) Handles btnHashTable.Click
        Dim weeks As New Hashtable
        Dim day As New DictionaryEntry
        weeks.Add("1", "Sun")
        weeks.Add("2", "Mon")
        weeks.Add("3", "Tue")
        weeks.Add("4", "Wed")
        weeks.Add("5", "Thu")
        weeks.Add("6", "Fri")
        weeks.Add("7", "Sat")
        'Display a single item
        MsgBox(weeks.Item("2"))
        'Search an item
        If weeks.ContainsValue("Tue") Then
            MsgBox("Found")
        Else
            MsgBox("Not Found")
        End If
        'Remove an item
        weeks.Remove("3")
        For Each day In weeks
            MsgBox("Key: " + day.Key + ", Value: " + day.Value)
        Next
    End Sub

    Private Sub btnStack_Click(sender As Object, e As EventArgs) Handles btnStack.Click
        'LIFO: Last In Last Out
        Dim stackTable As New Stack
        stackTable.Push("Sun")
        stackTable.Push("Mon")
        stackTable.Push("Tue")
        stackTable.Push("Wed")
        stackTable.Push("Thu")
        stackTable.Push("Fri")
        stackTable.Push("Sat")
        If stackTable.Contains("Tue") Then
            MsgBox("Found TUESDAY on the stack")
            MsgBox("Stack before POP operation: " + stackTable.Count.ToString + " elements")
            stackTable.Pop()
            MsgBox("Stack after POP operation: " + stackTable.Count.ToString + " elements")
            'Display the stack
            For Each elem In stackTable
                MsgBox(elem)
            Next
        Else
            MsgBox("TUESDAY was not found on the stack")
        End If
    End Sub

    Private Sub btnQueue_Click(sender As Object, e As EventArgs) Handles btnQueue.Click
        'FIFO: First In First Out
        Dim queueList As New Queue
        queueList.Enqueue("Sun")
        queueList.Enqueue("Mon")
        queueList.Enqueue("Tue")
        queueList.Enqueue("Wed")
        queueList.Enqueue("Thu")
        queueList.Enqueue("Fri")
        queueList.Enqueue("Sat")
        MsgBox("Queue before DEQUEUE operation: " + queueList.Count.ToString + " elements")
        queueList.Dequeue()
        MsgBox("Queue after DEQUEUE operation: " + queueList.Count.ToString + " elements")
        MsgBox(queueList.Peek())
        If queueList.Contains("Sun") Then
            MsgBox("SUNDAY found")
        Else
            MsgBox("SUNDAY was not found")
        End If
    End Sub
End Class
