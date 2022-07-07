Imports System

Module Program

    'グローバル変数　publicは他のファイルからも参照できる。privateはclass内で参照できる
    Public aaa As String = "hoge"
    Private aaa As Integer = 100

    'グローバル定数
    Public Const aaa As String = "hoge"

    Sub Main()

        '変数
        Dim aaa As String = "hello world"

        '定数
        Const aaa As String = "hogehoge"

        '演算子
        Dim aaa As Integer = 10
        aaa = aaa Mod 3　'余り

        '比較演算子
        If aaa <> aaa Then '不等式
        End If

        'Not
        Dim aaa As Boolean = True
        aaa = Not aaa 'falseに反転

        'インクリメント
        aaa += 1

        '論理演算子
        If (aaa = aaa) AndAlso (aaa = aaa) Then
            'AndAlsoはandの性質に加え
            '1つ目の条件がfalseならそれ以降は処理を飛ばす
        End If

        If (aaa = aaa) AndAlso (aaa = aaa) Then
            'Orelseはorの性質に加え
            'OrElseは1つ目の条件がtrueならそれ以降は処理を飛ばす
        End If

        'Select case文
        Dim aaa As Integer = 80
        Select Case aaa
            Case 90 To 100
                Console.WriteLine("秀")
            Case 80 To 89
                Console.WriteLine("優")
            Case 70 To 79
                Console.WriteLine("良")
            Case Else
                Console.WriteLine("可")
        End Select

    End Sub



End Module
