Imports System

Module Program

    Sub Main()
        '�O���[�o���ϐ��@public�͑��̃t�@�C��������Q�Ƃł���Bprivate��class���ŎQ�Ƃł���
        Public aaa As String = "hoge"
        Private aaa As Integer = 100

        '�O���[�o���萔
        Public Const aaa As String = "hoge"
    End Sub


    Sub Main()


        '�ϐ�
        Dim aaa As String = "hello world"

        '�萔
        Const aaa As String = "hogehoge"

        '������̌���
        Dim aaa, bbb As String
        aaa = "hello"
        bbb = "world"
        MsgBox(aaa & bbb) '+�ł�ok����&����
        MsgBox($"{aaa}!!!{bbb}!!!!")

        '���l�̈���
        Dim x As Decimal = 815.6D '����D�̓f�W�}���ł��邱�Ƃ𖾎�����B�^�𖾊m�ɂ���ق����悢

        '�����_
        Dim aaa As Decimal = 123.4D
        Dim bbb As String = aaa.ToString("0.00")
        Console.WriteLine(bbb) '123.40�@��0���⊮�����
        '���ꕶ��
        Console.WriteLine(" ""hello ") '  "��""�Ƃ���B�@"hello �Əo�́B
        Console.WriteLine("���s" & vbCrLf) '���s

        '���t
        Dim day As Date = #6/27/2020#
        MsgBox(day) '�����w��Ȃ��BWindows�̐ݒ�ŏ������B
        MsgBox(day.ToString("yyyy�NMM��dd��")) '2020�N06��27��
        MsgBox(day.ToString("yy-MM-dd")) '20-06-27
        day = Now '���ݓ��t����
        MsgBox(Now.ToString("HH:mm:ss")) '����

        '���Z�q
        Dim aaa As Integer = 10
        aaa = aaa Mod 3�@'�]��

        '��r���Z�q
        If aaa <> aaa Then '�s����
        End If

        'Not
        Dim aaa As Boolean = True
        aaa = Not aaa 'false�ɔ��]

        '�C���N�������g
        aaa += 1

        '�z��
        Dim aaa(3) As String
        aaa(0) = "hoge"

        '�z��ϐ����ォ��ύX
        ReDim aaa(5)

        '�z��@�錾�Ə�����
        Dim aaa() As String = {"hoge", "foo"} '()�ɐ��l�͕s�v�ɂȂ�
        Dim aaa() = {"hoge", "foo"} '�^���_�@�^�����炩�ȏꍇ�͌^�w����ȗ͂ł���

        '�z��̗v�f�����擾
        aaa.Length

        '�z��̃\�[�g
        Array.Sort(aaa)
        Array.Reverse(aaa)

        '����
        Dim aaa() As String = {"hoge", "foo"}
        Array.IndexOf(aaa, "hoge") '���̏ꍇ�P�Ԗڂ̗v�f�̂Ȃ̂Ł@0 ���o�͂����


        '�񎟌��z��
        Dim aaa(2, 3) As String
        aaa(0, 0) = "aaa"
        aaa(0, 1) = "bbb"
        aaa(0, 2) = "ccc"
        aaa(0, 3) = "ddd"

        '�_�����Z�q
        If (aaa = aaa) AndAlso (aaa = aaa) Then
            'AndAlso��and�̐����ɉ���
            '1�ڂ̏�����false�Ȃ炻��ȍ~�͏������΂�
        End If

        If (aaa = aaa) OrElse (aaa = aaa) Then
            'Orelse��or�̐����ɉ���
            'OrElse��1�ڂ̏�����true�Ȃ炻��ȍ~�͏������΂�
        End If

        'Select case��
        Dim aaa As Integer = 80
        Select Case aaa
            Case 90 To 100
                Console.WriteLine("�G")
                Exit Select 'Exit Select���g���Ɣ����o��
            Case 80 To 89
                Console.WriteLine("�D")
            Case 70 To 79
                Console.WriteLine("��")
            Case Else
                Console.WriteLine("��")
        End Select

        '�O�����Z�q
        Dim aaa As String = If(10 = 10, "����", "�ԈႢ") 'aaa�ɂ͐������Ԃ��Ă���

        '���X�g�^
        Dim aaa As New List(Of String)
        aaa.Add("hoge") '�ǉ�
        aaa.Add("foo")
        aaa.Add("hogehoge")
        aaa.Remove("hoge") '�폜
        aaa.Clear() '�f�[�^�̑S�폜�B��̗v�f�͎c��i���͂��̂܂�)
        aaa = Nothing '�v�f���폜�B���S������
        aaa.Count() '�f�[�^�̌�
        Console.WriteLine(aaa(0))

        'for��
        Dim aaa As Integer
        For i = 1 To 5
            aaa.Add("hoge") '��)���X�g�ɒǉ�
            'i += 1 �Ȃǂ̃R�[�h���Ȃ��Ă�������+1�����
            '�t�Ɂ@i += 1 �������Ǝ��ۂ�+2�ŌJ��Ԃ���� 
        Next

        For i As Integer = 1 To 5 '����ł�Ok
            aaa.Add("hoge")
        Next

        'for���@step  +1�ȊO�̒l��ݒ�B-���\
        For i = 1 To 10 Step 2
            Console.Write(i)  '1 3 5 7 9���o�͂����
        Next i

        '���[�v�𔲂���(Exit For)
        For i = 0 To 10
            If i = 3 Then
                Exit For
            End If
            Console.Write(i) ' 0 1 2�܂ŏo�͂����
        Next

        '�����ŃX�L�b�v Continue Fo
        For i = 0 To 10
            If i = 5 Then
                Continue For
            End If
            Console.Write(i) '5�ȊO���o�͂����
        Next

        'for each�� ���X�g�����[�v������
        For Each aa As String In aaa
            Console.WriteLine(aa)
        Next

        'do until�@ ������v�܂ŏ���
        Dim aaa As Integer = 0
        Do Until aaa = 5 '�ŏ��ɏI�������𖾎�
            Console.WriteLine(aaa)
            aaa += 1
        Loop

        Do
            Console.WriteLine(aaa)
            aaa += 1
        Loop Until aaa = 5 '�Ō�ɏI�������𖾎�

        'do while ������v�̂ݏ���
        Dim aaa As Integer = 0
        Do While aaa = 5
            Console.WriteLine(aaa)
        Loop

        Do
            Console.WriteLine(aaa)
        Loop While aaa = 5

    End Sub

    '����
    Private Sub xxx(ByVal aaa As Integer, ByVal bbb As String) 'byval�͏ȗ���
        Console.WriteLine(aaa)
        Console.WriteLine(bbb)
    End Sub

    '�I�v�V�������� �����l��ݒ肷��B
    Private Sub xxx(aaa As Integer,
                    Optional bbb As String = "hoge")
        Console.WriteLine(aaa)
        Console.WriteLine(bbb)
    End Sub
    xxx(100) '100 hoge �Əo��
    xxx(100,"foo")�@'100 foo �Əo��

    '�I�v�V�������� �����̏ꍇ ������ := �Œl��ݒ�
    Private Sub xxx(aaa As Integer,
                    Optional bbb As String = "hoge",
                    Optional ccc As String = "foo")
        Console.WriteLine(aaa)
        Console.WriteLine(bbb)
        Console.WriteLine(ccc)
    End Sub
    xxx(100,,ccc:="hogehoge")�@'100 hoge hogehoge �Əo��

    '�Q�Ɠn���@���̒l�ɉe�����y�ڂ�
    Dim aaa As Integer = 100
    Private Sub xxx(ByRef aaa As Integer)
        aaa = 200
    End Sub
    xxx(aaa) '�֐������s����Ƃ��Ƃ�aaa�̒l��200�ɕύX����Ă���
    Console.WriteLine(aaa)


    'function�v���V�[�W���@�Ԃ�l������֐��B�^�̎w�������
    Private Function xxx() As String
        Return "hoge"
    End Function

End Module
