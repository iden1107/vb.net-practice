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

        '文字列の結合
        Dim aaa, bbb As String
        aaa = "hello"
        bbb = "world"
        MsgBox(aaa & bbb) '+でもokだが&推奨
        MsgBox($"{aaa}!!!{bbb}!!!!")

        '数値の扱い
        Dim x As Decimal = 815.6D '後ろのDはデジマルであることを明示する。型を明確にするほうがよい

        '小数点
        Dim aaa As Decimal = 123.4D
        Dim bbb As String = aaa.ToString("0.00")
        Console.WriteLine(bbb) '123.40　と0が補完される
        '特殊文字
        Console.WriteLine(" ""hello ") '  "は""とする。　"hello と出力。
        Console.WriteLine("改行" & vbCrLf) '改行


        '日付
        Dim day As Date = #6/27/2020#
        MsgBox(day) '書式指定なし。Windowsの設定で書式化。
        MsgBox(day.ToString("yyyy年MM月dd日")) '2020年06月27日
        MsgBox(day.ToString("yy-MM-dd")) '20-06-27
        day = Now '現在日付時刻
        MsgBox(Now.ToString("HH:mm:ss")) '時刻

        '演算子
        Dim aaa As Integer = 10b
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

        If (aaa = aaa) OrElse (aaa = aaa) Then
            'Orelseはorの性質に加え
            'OrElseは1つ目の条件がtrueならそれ以降は処理を飛ばす
        End If

        'Select case文
        Dim aaa As Integer = 80
        Select Case aaa
            Case 90 To 100
                Console.WriteLine("秀")
                Exit Select 'Exit Selectを使うと抜け出す
            Case 80 To 89
                Console.WriteLine("優")
            Case 70 To 79
                Console.WriteLine("良")
            Case Else
                Console.WriteLine("可")
        End Select

        '三項演算子
        Dim aaa As String = If(10 = 10, "正解", "間違い") 'aaaには正解が返ってくる

        'リスト型
        Dim aaa As New List(Of String)
        aaa.Add("hoge") '追加
        aaa.Add("foo")
        aaa.Add("hogehoge")
        aaa.Remove("hoge") '削除
        aaa.Clear() 'データの全削除。空の要素は残る（個数はそのまま)
        aaa = Nothing '要素も削除。完全初期化
        aaa.Count() 'データの個数
        Console.WriteLine(aaa(0))

        'for文
        Dim aaa As Integer
        For i = 1 To 5
            aaa.Add("hoge") '例)リストに追加
            'i += 1 などのコードがなくても自動で+1される
            '逆に　i += 1 を書くと実際は+2で繰り返される 
        Next

        For i As Integer = 1 To 5 'これでもOk
            aaa.Add("hoge")
        Next

        'for分　step  +1以外の値を設定。-も可能
        For i = 1 To 10 Step 2
            Console.Write(i)  '1 3 5 7 9が出力される
        Next i

        'ループを抜ける(Exit For)
        For i = 0 To 10
            If i = 3 Then
                Exit For
            End If
            Console.Write(i) ' 0 1 2まで出力される
        Next

        '条件でスキップ Continue Fo
        For i = 0 To 10
            If i = 5 Then
                Continue For
            End If
            Console.Write(i) '5以外が出力される
        Next

        'for each文 リストをループさせる
        For Each aa As String In aaa
            Console.WriteLine(aa)
        Next

        'do until　 条件一致まで処理
        Dim aaa As Integer = 0
        Do Until aaa = 5 '最初に終了条件を明示
            Console.WriteLine(aaa)
            aaa += 1
        Loop

        Do
            Console.WriteLine(aaa)
            aaa += 1
        Loop Until aaa = 5 '最後に終了条件を明示

        'do while 条件一致のみ処理
        Dim aaa As Integer = 0
        Do While aaa = 5
            Console.WriteLine(aaa)
        Loop

        Do
            Console.WriteLine(aaa)
        Loop While aaa = 5

    End Sub

    '引数
    Private Sub xxx(ByVal aaa As Integer, ByVal bbb As String) 'byvalは省略可
        Console.WriteLine(aaa)
        Console.WriteLine(bbb)
    End Sub

    'オプション引数 初期値を設定する。
    Private Sub xxx(aaa As Integer,
                    Optional bbb As String = "hoge")
        Console.WriteLine(aaa)
        Console.WriteLine(bbb)
    End Sub
    xxx(100) '100 hoge と出力
    xxx(100,"foo")　'100 foo と出力

    'オプション引数 複数の場合 引数に := で値を設定
    Private Sub xxx(aaa As Integer,
                    Optional bbb As String = "hoge",
                    Optional ccc As String = "foo")
        Console.WriteLine(aaa)
        Console.WriteLine(bbb)
        Console.WriteLine(ccc)
    End Sub
    xxx(100,,ccc:="hogehoge")　'100 hoge hogehoge と出力

    '参照渡し　元の値に影響を及ぼす
    Dim aaa As Integer = 100
    Private Sub xxx(ByRef aaa As Integer)
        aaa = 200
    End Sub
    xxx(aaa) '関数を実行するともとのaaaの値が200に変更されている
    Console.WriteLine(aaa)


    'functionプロシージャ　返り値がある関数。型の指定をする
    Private Function xxx() As String
        Return "hoge"
    End Function

End Module
