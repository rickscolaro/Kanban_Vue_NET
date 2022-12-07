/* eslint-disable no-use-before-define */

export interface Todo {
  id: number
  titulo: string
  descricao: string
  status: TodoStatus
}

export enum TodoStatus {
  Pendente = 'pendente',
  EmProgresso = 'emProgresso',
  Completo = 'completo',
}

export enum EnumTodoStatus {
  EM_PLANEJAMENTO = 1,
  EM_PRODUCAO = 2,
  FINALIZADO = 3,
}

export interface TodoProduto {
  produtoId: number
  descricao: string
  quantidade: number
  situacao: EnumTodoStatus
  clienteId: number
}
