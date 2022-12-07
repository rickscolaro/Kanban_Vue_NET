<script setup lang="ts">
import useTodos from 'src/store/useTodos'
import { Todo, TodoStatus } from 'src/types/types'
import { reactive, ref } from 'vue'

interface Props {
  status: TodoStatus
}
const props = defineProps<Props>()

const shouldDisplayForm = ref(false)

const { addNewTodo } = useTodos()

// Omit é para não precisar colocar om id
const newTodo = reactive<Omit<Todo, 'id'>>({
  // id: 0,
  titulo: '',
  descricao: '',
  status: props.status,
})

const resetForm = () => {
  shouldDisplayForm.value = false
  newTodo.titulo = ''
  newTodo.descricao = ''
}

const handleOnSubmit = () => {
  // add new todo

  // id: Math.random() é para poder gerar os ids
  addNewTodo({ id: Math.random(), ...newTodo })

  resetForm()
}
</script>
<template>
  <div>
    <h3
      v-if="!shouldDisplayForm"
      @click="shouldDisplayForm = !shouldDisplayForm"
    >
      Add New
    </h3>
    <template v-else>
      <form @submit.prevent="handleOnSubmit">
        <div>
          <input type="text" placeholder="Title" v-model="newTodo.titulo" />
        </div>
        <div>
          <textarea
            type="text"
            placeholder="Title"
            v-model="newTodo.descricao"
          />
        </div>
        <button type="submit">Submit</button>
        <button type="button" @click="resetForm">Cancel</button>
      </form>
    </template>
  </div>
</template>
