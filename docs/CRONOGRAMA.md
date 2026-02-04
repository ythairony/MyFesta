# 📅 Cronograma de Implementação - MyFesta

Este cronograma divide o desenvolvimento do projeto em 6 etapas lógicas, focando primeiro na base técnica e depois nas funcionalidades de negócio.

---

## 🏗️ Fase 1: Fundação e Setup (Semana 1) 🟢
*Objetivo: Configurar o ambiente e o núcleo de dados.*

- [ ] **Setup Backend:** Criar projeto .NET Web API, configurar Entity Framework e SQL Server. ✅
- [ ] **Modelagem:** Criar as entidades (Models) de Fornecedor, Oferta e Categoria. ✅
- [ ] **Setup Frontend:** Criar projeto Angular, configurar roteamento e serviços básicos. ⏳
- [ ] **Base de Dados:** Criar as migrations iniciais e popular a tabela de Categorias. ⏳

## 🏢 Fase 2: Área do Fornecedor - Perfil e Ofertas (Semana 2) 🚧
*Objetivo: Permitir que o fornecedor coloque o seu serviço no sistema.*

- [ ] **Auth:** Implementar Cadastro e Login (Identity/JWT).
- [ ] **Perfil:** CRUD de informações gerais do fornecedor.
- [ ] **Ofertas:** Tela de criação de ofertas (definindo se é Local Fixo ou Móvel).
- [ ] **Upload:** Implementar o serviço de armazenamento de imagens para o Portfólio.

## 🔍 Fase 3: Motor de Busca e Geolocalização (Semana 3) 🚧
*Objetivo: A parte mais crítica - fazer o cliente encontrar o fornecedor.*

- [ ] **API de Busca:** Desenvolver o endpoint de filtro por cidade e tipo de festa.
- [ ] **Lógica de Raio:** Implementar o cálculo de distância no .NET para serviços móveis.
- [ ] **Frontend Home:** Criar a página inicial com os filtros de busca.
- [ ] **Resultados:** Criar os "Cards" de fornecedores com foto principal e resumo.

## 📦 Fase 4: Pacotes e Captação de Leads (Semana 4) 🚧
*Objetivo: Funcionalidades de negócio para gerar valor ao fornecedor.*

- [ ] **Gestão de Pacotes:** CRUD de pacotes dentro da oferta do fornecedor.
- [ ] **Preço Privado:** Lógica de esconder o preço e mostrar o formulário de contato.
- [ ] **Lead Storage:** Criar tabela para salvar os contatos dos clientes interessados.
- [ ] **WhatsApp:** Gerador dinâmico de links para contato direto.

## 🛡️ Fase 5: Painel Administrativo e Qualidade (Semana 5) 🚧
*Objetivo: Gestão da plataforma e confiança do usuário.* 

- [ ] **Admin Dashboard:** Listagem de fornecedores para moderação.
- [ ] **Suspensão:** Fluxo de suspensão com envio de motivo (Simulação de E-mail/Log).
- [ ] **Avaliações:** Sistema de nota de 1 a 10 (Backend e Frontend).
- [ ] **Filtros Avançados:** Ordenar por "Melhores Avaliados".

## 🚀 Fase 6: Polimento e Deployment (Semana 6) 🚧
*Objetivo: Finalização e portfólio.*

- [ ] **Refatoração:** Revisar códigos e tratar erros (Exception Handling).
- [ ] **UI/UX:** Ajustar a responsividade para telemóveis (Mobile-first).
- [ ] **Documentação Final:** Atualizar o README do GitHub com prints e instruções de execução.
- [ ] **Deploy:** Publicar (ex: Azure, Heroku ou Render) para demonstração.

---

## 🛠️ Ferramentas de Apoio Sugeridas
- **GitHub Projects / Trello:** Para mover as tarefas de "A fazer" para "Feito".
- **Postman:** Para testar os endpoints da API .NET.
- **Swagger:** Para documentar a API (já vem no .NET).