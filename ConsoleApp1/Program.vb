Imports System

Module Program

    '�O���[�o���ϐ��@public�͑��̃t�@�C��������Q�Ƃł���Bprivate��class���ŎQ�Ƃł���
    Public aaa As String = "hoge"
    Private aaa As Integer = 100

    '�O���[�o���萔
    Public Const aaa As String = "hoge"

    Sub Main()

        '�ϐ�
        Dim aaa As String = "hello world"

        '�萔
        Const aaa As String = "hogehoge"

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

        '�_�����Z�q
        If (aaa = aaa) AndAlso (aaa = aaa) Then
            'AndAlso��and�̐����ɉ���
            '1�ڂ̏�����false�Ȃ炻��ȍ~�͏������΂�
        End If

        If (aaa = aaa) AndAlso (aaa = aaa) Then
            'Orelse��or�̐����ɉ���
            'OrElse��1�ڂ̏�����true�Ȃ炻��ȍ~�͏������΂�
        End If

        'Select case��
        Dim aaa As Integer = 80
        Select Case aaa
            Case 90 To 100
                Console.WriteLine("�G")
            Case 80 To 89
                Console.WriteLine("�D")
            Case 70 To 79
                Console.WriteLine("��")
            Case Else
                Console.WriteLine("��")
        End Select

    End Sub



End Module
