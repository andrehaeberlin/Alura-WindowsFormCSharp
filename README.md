# Windows Forms com C# — Alura

Projeto de estudos de aplicativos desktop Windows com C# e Windows Forms. A aplicação evolui de formulários básicos para uma interface de gerenciamento de clientes inspirada no ByteBank.

## Estrutura

| Caminho | Responsabilidade |
| --- | --- |
| `CursoWindowsForms.sln` | Solução do Visual Studio |
| `CursoWindowsForms/` | Formulários, menus, componentes de usuário, cadastro e busca |
| `CursoWindowsFormsBiblioteca/` | Biblioteca de clientes, CEP, validações, fichário e acesso a dados |
| `Fichario/` | Exemplos de registros JSON |

Os exercícios incluem eventos de teclado e mouse, máscaras, validação de CPF e senha, imagens, login, menus MDI e User Controls. A entrada atual é `Frm_Principal_Menu_UC`, definida em `Program.cs`.

## Como executar

1. No Windows, instale o Visual Studio com desenvolvimento desktop .NET e .NET Framework 4.7.2 Developer Pack.
2. Abra `CursoWindowsForms.sln` e restaure os pacotes NuGet. A biblioteca referencia `Newtonsoft.Json` 12.0.3.
3. Defina `CursoWindowsForms` como projeto de inicialização, compile e execute com F5.

Os exercícios de armazenamento incluem arquivos JSON, LocalDB e SQL Server; a parte de banco de dados depende da configuração local correspondente. Projeto de aprendizado legado, não sistema bancário de produção.
