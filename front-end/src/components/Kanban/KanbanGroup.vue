<template>
  <div class="group-wrapper">
    <!-- <h3>{{ groupLabel[props.status] }}</h3> -->

    <Draggable
      class="draggable"
      :list="produtoArray"
      group="todos"
      item-key="produtoId"
      @change="onDraggableChange"
    >
      <template #item="{ element: todo }">
        <li>
          <div>
            <span class="todo-description"> {{ todo.produtoId }}</span>
          </div>
          <div>
            <span class="todo-description">{{ todo.descricao }}</span>
          </div>
          <div>
            <span class="todo-description">{{ todo.quantidade }}</span>
          </div>
          <div>
            <span class="todo-description">{{ todo.clienteId }}</span>
          </div>
          <div>
            <span class="todo-description">{{ todo.situacao }}</span>
          </div>
        </li>
      </template>
    </Draggable>
  </div>
</template>
<script setup lang="ts">
import { TodoProduto, TodoStatus, EnumTodoStatus } from 'src/types/types'
import { reactive, computed, ref, onMounted } from 'vue'
import Draggable from 'vuedraggable'

import postService from 'src/services/posts'

onMounted(() => {
  getProduto()
})

const { list } = postService()

interface Props {
  status: EnumTodoStatus
  title: string
  // ordemProducao: TodoProduto
}

const props = defineProps<Props>()

// const produtoModel = ref<TodoProduto>({
//   produtoId: 2,
//   descricao: 'IPhone',
//   quantidade: 25,
//   situasao: 1,
//   clienteId: 5,
// })

// interface TodoStore {
//   EM_PLANEJAMENTO: TodoProduto[]
//   EM_PRODUCAO: TodoProduto[]
//   FINALIZADO: TodoProduto[]
// }

// const { getTodoByStatus, deleteTodo, updateTodo } = useTodos()

const produtoArray = reactive<Array<TodoProduto>>([])

// Vou renderizar na coluna respectiva oque tiver dentro do arrai baseado em seu enum
// const todoStore = reactive<TodoStore>({
//   EM_PLANEJAMENTO: [],
//   EM_PRODUCAO: [],
//   FINALIZADO: [],
// })

// const todoStore2 = ref({
//   pendete: produtoArray.value.find(x => x.situacao)
// })

// const getTodoByStatus = (TodoStatus: TodoStatus) => {
//   return computed(() => todoStore[TodoStatus])
// }

// const todoList = computed(() => {
//   switch (props.status) {
//     case EnumTodoStatus.EM_PLANEJAMENTO:
//       return todoStore.EM_PLANEJAMENTO
//     case EnumTodoStatus.EM_PRODUCAO:
//       return todoStore.EM_PRODUCAO
//     default:
//       return todoStore.FINALIZADO
//   }
// })

// const todoListProduto = computed(() => {
//   const teste = produtoArray.filter((x) => x.situasao === props.status)
//   return teste
// })

const updateTodo = (todo: TodoProduto, newStatus: EnumTodoStatus) => {
  debugger
  console.log(props.title)
  todo.situacao = newStatus
}

// const groupLabel = {
//   [TodoStatus.Pendente]: 'Pendente',
//   [TodoStatus.EmProgresso]: 'EmProgresso',
//   [TodoStatus.Completo]: 'Completado',
// }

const onDraggableChange = (payload: any) => {
  console.log(props.title)
  if (payload?.added?.element) {
    // update todo status
    updateTodo(payload?.added?.element, props.status)
  }
}

const getProduto = async () => {
  try {
    const data = await list()
    // ordensPlanejameto =
    // produtoModel.value = data
    // produtoArray.value.push(produtoModel.value)
    // todoStore.pendente.push(produtoModel.value)

    produtoArray.push(...data.filter((d: any) => d.situacao === props.status))
  } catch (error) {
    console.log(error)
  }
}
</script>

<style scoped>
.group-wrapper {
  flex: 1;
  padding: 20px;
  background-color: rgb(56, 80, 103);
  width: 300px;
}

.group-wrapper li {
  list-style-type: none;
  background-color: aliceblue;
  color: rgb(56, 80, 103);
  padding: 2px 5px;
  cursor: grab;
  margin-bottom: 10px;
}

.draggable {
  min-height: 200px;
}

.delete-icon {
  float: right;
  cursor: pointer;
}

.todo-description {
  font-size: 12px;
}
</style>
