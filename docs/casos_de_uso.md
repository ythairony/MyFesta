# 🥳 MyFesta - Documentação de Casos de Uso

Este documento detalha os atores e as interações do sistema **MyFesta**, uma plataforma fullstack projetada para conectar fornecedores de serviços de eventos a clientes finais, focando na democratização e facilitação de celebrações.

---

## 👥 1. Atores do Sistema

| Ator | Papel e Responsabilidades |
| :--- | :--- |
| **Administrador** | Responsável pela moderação técnica e administrativa, gestão de categorias e suporte. |
| **Fornecedor** | Empresas ou autônomos que cadastram seus serviços, portfólios e pacotes. |
| **Cliente** | Usuários que buscam fornecedores. Pode navegar anonimamente ou avaliar quando autenticado. |

---

## 🛠️ 2. Mapeamento de Casos de Uso

### **Gestão Administrativa (Admin)**
* **[UC01] Gerenciar Categorias:** Criar, editar ou remover categorias de serviços (ex: Buffet, Fotografia, Decoração).
* **[UC02] Moderar Fornecedores:** Capacidade de suspender ou banir perfis. 
    * *Regra:* Ao suspender, o sistema obriga o envio de uma mensagem ao fornecedor justificando o motivo e os passos para reativação.
* **[UC03] Curadoria de Avaliações:** Excluir avaliações fraudulentas ou impróprias para garantir a saúde do ecossistema.

### **Gestão de Serviços (Fornecedor)**
* **[UC04] Manter Perfil:** Cadastro de dados básicos (CNPJ/CPF, Redes Sociais, WhatsApp).
* **[UC05] Gerenciar Ofertas de Serviço:** Um fornecedor pode criar múltiplas ofertas (ex: um salão que também oferece buffet). 
    * *Regra:* Cada oferta tem seu próprio portfólio e localização.
* **[UC06] Configurar Raio de Atendimento:** Para serviços móveis, definir um ponto central e um raio (km) de deslocamento.
* **[UC07] Definir Pacotes de Preço:** Criar combos de serviços.
    * *Privacidade:* Pacotes podem ser **Públicos** (valor visível) ou **Privados** (exige envio de contato do cliente/lead para visualização).

### **Experiência do Cliente (Visitante/Autenticado)**
* **[UC08] Buscar Fornecedores:** Filtrar por tipo de evento e cidade.
    * *Lógica:* O sistema cruza a cidade do cliente com o endereço da oferta ou com o raio de atendimento do fornecedor.
* **[UC09] Contato Direto:** Botão de redirecionamento dinâmico para o WhatsApp do fornecedor.
* **[UC10] Avaliar Fornecedor:** Atribuir nota de 1 a 10. (Requer autenticação).

---

## 📋 3. Regras de Negócio (RN)

1.  **Visibilidade Condicional:** Um fornecedor suspenso pelo Admin desaparece automaticamente de todos os filtros de busca.
2.  **Captura de Leads:** Para visualizar pacotes marcados como "Privados", o cliente deve fornecer nome e contato, que serão enviados ao fornecedor.
3.  **Localização Híbrida:** Ofertas do tipo "Local Fixo" usam o endereço físico; ofertas do tipo "Serviço Móvel" usam a lógica de Raio (Km).

---
> *Documento gerado como parte do planejamento de análise de requisitos do projeto MyFesta.*