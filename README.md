# Intcom Test

> Este arquivo contém os passos para executar a aplicação e como se logar nela.


### Banco  de Dados
---
 Para rodar o primeiro é necessário executar o script de banco (IntcomTestDB) este arquivo criará, caso não exista, o banco, tabelas e fará insert de algumas registros. 


### API .NET 
 A Api deve ser executada em mode debug na porta 44398 para que o front consiga acessa-la. 
 Para acessa-la pode-se abrir a solution  acessando a pasta 'IntcomTestApp' que se encontra dentro da pasta INTCOM (pasta raiz deste arquivo).

 Caminho: 'INTCOM/IntcomTestApp'

 ### Aplicação Angular
 O projeto angular está localizado dentro da pasta 'IntcomTesteApp' localizada na mesma pasta da solution da web api. 
 
 Caminho: 'INTCOM/IntcomTestApp/IntcomTesteApp'

 Antes de executar a aplicação é necessário rodar o comando 'npm install' para que as dependências sejam baixadas. Após finalizado é só rodar ng serve --open que o projeto será exibido no navegador. 

---
---

### Login
Caso não se deseje fazer o cadastro de um novo usuário, pode-se usar um dos abaixo. Estes usuários foram criados pelo script do banco, a fim de já se ter algum login de teste. 

- Email: teste@intcom.com / Senha:teste
- Email: vitor@gmail.com / Senha: teste
- Email: mauricio@intcom.com / Senha: teste

---
---

## Considerações 
 
Este arquivo não tem como inteção ofender ninguém ou insinuar que a pessoa não saiba os passos para execução do projeto. 

A aplicação backend foi escrita em pt-br, normalmente não sigo este padrão, mas tentei seguir ao máximo os arquivos recebidos e como no MER os nomes das tabelas estavam em portugues, segui desta forma. No entando a aplicação frontend esta em ingles. 

Por fim, obrigado pela oportunidade.

