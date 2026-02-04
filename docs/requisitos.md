# 📋 Especificação de Requisitos - MyFesta

Este documento descreve os Requisitos Funcionais (RF), Não-Funcionais (RNF) e as Regras de Negócio (RN) que regem o desenvolvimento da plataforma MyFesta.

---

## 1. Requisitos Funcionais (RF)
*Ações que o sistema deve ser capaz de executar.*

| ID | Nome | Descrição |
| :--- | :--- | :--- |
| **RF01** | **Cadastro de Fornecedor** | O sistema deve permitir que fornecedores se cadastrem informando CNPJ/CPF, Nome Fantasia, WhatsApp principal e links de redes sociais. |
| **RF02** | **Gestão de Ofertas Híbridas** | O fornecedor deve poder criar ofertas distintas, definindo se a oferta possui um **Local Fixo** (endereço completo) ou é um **Serviço Móvel** (cidade base + raio de atendimento). |
| **RF03** | **Portfólio de Imagens** | Cada oferta de serviço deve possuir sua própria galeria de imagens para demonstração do trabalho realizado. |
| **RF04** | **Configuração de Raio (Km)** | Para serviços móveis, o fornecedor deve definir um raio de distância (em km) que está disposto a percorrer a partir de sua origem. |
| **RF05** | **Pacotes de Preços** | O sistema deve permitir o cadastro de pacotes pré-definidos (ex: "Pacote 100 Salgados"). |
| **RF06** | **Modo de Preço Privado** | O fornecedor pode marcar um pacote como "Privado". Neste caso, o preço fica oculto e o sistema exige nome/contato do cliente (Lead) para liberá-lo. |
| **RF07** | **Busca por Geolocalização** | O cliente deve filtrar fornecedores por cidade. O sistema deve retornar locais fixos naquela cidade e serviços móveis cujo raio de atendimento alcance a cidade filtrada. |
| **RF08** | **Integração com WhatsApp** | O sistema deve gerar links automáticos para o WhatsApp do fornecedor, incluindo uma mensagem de saudação identificando o serviço de interesse. |
| **RF09** | **Painel Administrativo** | O administrador deve poder visualizar, suspender ou banir fornecedores, além de gerenciar a lista de categorias do sistema. |
| **RF10** | **Sistema de Avaliação** | O sistema deve permitir que usuários logados atribuam uma nota de 1 a 10 ao fornecedor. |

---

## 2. Requisitos Não-Funcionais (RNF)
*Atributos de qualidade e restrições técnicas.*

* **RNF01 - Tecnologias Core:** O backend deve ser desenvolvido em **.NET** (C#) e o frontend em **Angular**.
* **RNF02 - Persistência de Dados:** Deve ser utilizado um banco de dados relacional (ex: SQL Server ou PostgreSQL).
* **RNF03 - Responsividade:** A interface deve ser totalmente responsiva (*Mobile-First*), focando no uso via smartphones.
* **RNF04 - Autenticação:** O acesso ao painel do fornecedor e do administrador deve ser protegido por autenticação via **JWT (JSON Web Token)**.
* **RNF05 - Performance de Busca:** As consultas de filtragem por geolocalização devem ser otimizadas para retornar resultados em menos de 1 segundo.
* **RNF06 - Validação de Dados:** O sistema deve validar formatos de documentos (CPF/CNPJ) e números de telefone no frontend e no backend.

---

## ⚖️ 3. Regras de Negócio (RN)
*Regras e restrições que definem o comportamento lógico do software.*

* **RN01 - Visibilidade de Suspensão:** Fornecedores com status "Suspenso" ou "Banido" não devem aparecer em nenhum resultado de busca para o cliente.
* **RN02 - Notificação de Suspensão:** Ao suspender um fornecedor, o sistema exige que o Administrador insira um motivo, que será enviado ao fornecedor para orientação.
* **RN03 - Captura de Leads:** Os dados capturados através de pacotes "Privados" devem ser armazenados e disponibilizados apenas para o fornecedor dono daquela oferta.
* **RN04 - Avaliação Única:** Um cliente só pode avaliar o mesmo fornecedor uma única vez, evitando manipulação de médias.
* **RN05 - Raio de Atendimento Zero:** Caso o fornecedor defina o raio como 0km, o sistema assumirá que ele atende exclusivamente na sua cidade de origem.

---
> *Este documento é dinâmico e será atualizado conforme a evolução do projeto MyFesta.*