Imports System.Collections.Specialized

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
        '=====================================================
        'ARRAY LIST
        '=====================================================
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
        '=====================================================
        'HASH TABLE
        '=====================================================
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
            MsgBox("Key: " & day.Key & ", Value: " & day.Value)
        Next
    End Sub

    Private Sub btnStack_Click(sender As Object, e As EventArgs) Handles btnStack.Click
        '=====================================================
        'STACK (LIFO - Last In Last Out)
        '=====================================================
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
            MsgBox("Stack before POP operation: " & stackTable.Count.ToString & " elements")
            stackTable.Pop()
            MsgBox("Stack after POP operation: " & stackTable.Count.ToString & " elements")
            'Display the stack
            For Each elem In stackTable
                MsgBox(elem)
            Next
        Else
            MsgBox("TUESDAY was not found on the stack")
        End If
    End Sub

    Private Sub btnQueue_Click(sender As Object, e As EventArgs) Handles btnQueue.Click
        '=====================================================
        'STACK (FIFO - First In First Out)
        '=====================================================
        Dim queueList As New Queue
        queueList.Enqueue("Sun")
        queueList.Enqueue("Mon")
        queueList.Enqueue("Tue")
        queueList.Enqueue("Wed")
        queueList.Enqueue("Thu")
        queueList.Enqueue("Fri")
        queueList.Enqueue("Sat")
        MsgBox("Queue before DEQUEUE operation: " & queueList.Count.ToString & " elements")
        queueList.Dequeue()
        MsgBox("Queue after DEQUEUE operation: " & queueList.Count.ToString & " elements")
        MsgBox(queueList.Peek())
        If queueList.Contains("Sun") Then
            MsgBox("SUNDAY found")
        Else
            MsgBox("SUNDAY was not found")
        End If
    End Sub

    Private Sub btnArrays_Click(sender As Object, elem As EventArgs) Handles btnArrays.Click
        '=====================================================
        'ARRAYS
        '=====================================================
        Dim i As Integer
        Dim week(6) As String
        week(0) = "Sunday"
        week(1) = "Monday"
        week(2) = "Tuesday"
        week(3) = "Wednesday"
        week(4) = "Thursday"
        week(5) = "Friday"
        week(6) = "Saturday"
        MsgBox("Array before RESIZE operation: " & week.Length.ToString & " elements")
        For i = 0 To week.Length - 1
            MsgBox(week(i))
        Next
        Array.Resize(week, 3)
        MsgBox("Array after RESIZE operation: " & week.Length.ToString & " elements")

        Dim arr As Integer() = {10, 30, 50}
        For Each e As Integer In arr
            MsgBox(e)
        Next
    End Sub

    Private Sub btnDynamicArrays_Click(sender As Object, e As EventArgs) Handles btnDynamicArrays.Click
        '=====================================================
        'DYNAMIC ARRAYS
        '=====================================================
        Dim i As Integer
        Dim scores() As Integer

        ReDim scores(1)
        scores(0) = 100
        scores(1) = 200

        MsgBox("Array before RESIZING operation: " & scores.Length.ToString & " elements")
        For i = 0 To scores.Length - 1
            MsgBox(scores(i))
        Next

        ReDim Preserve scores(2)
        scores(2) = 300

        MsgBox("Array after RESIZING operation: " & scores.Length.ToString & " elements")
        For i = 0 To scores.Length - 1
            MsgBox(scores(i))
        Next
    End Sub

    Private Sub btnNameValueCollection_Click(sender As Object, e As EventArgs) Handles btnNameValueCollection.Click
        '=====================================================
        'NAME VALUE COLLECTION
        '=====================================================
        Dim cities As New NameValueCollection
        Dim key As String
        Dim values() As String

        cities.Add("CO", "Fort Collins")
        cities.Add("CO", "Denver")
        cities.Add("CA", "Palo Alto")
        cities.Add("NY", "New York")

        For Each key In cities.Keys
            values = cities.GetValues(key)
            MsgBox("State: " & key & " ==================================")
            For Each value In values
                MsgBox("Key: " & key & ", Value: " & value)
            Next value
        Next key
    End Sub
End Class
