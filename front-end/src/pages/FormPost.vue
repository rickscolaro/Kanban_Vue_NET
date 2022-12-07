<template>
  <q-page padding>
    <q-form @submit="onSubmit" class="row q-col-gutter-sm">
      <q-input
        outlined
        v-model="form.title"
        label="Titulo"
        lazy-rules
        :rules="[(val) => (val && val.length > 0) || 'Campo obrigatório']"
        class="col-lg-6 col-xs-12"
      />

      <q-input
        outlined
        v-model="form.author"
        label="Autor"
        lazy-rules
        :rules="[(val) => (val && val.length > 0) || 'Campo Obrigtório']"
        class="col-lg-6 col-xs-12"
      />

      <div class="col-lg-12 colxs-12">
        <q-editor v-model="form.content" min-height="rem" />
      </div>

      <div class="col-12 q-gutter-sm">
        <q-btn label="Salvar" type="submit" color="primary" icon="save" />
        <q-btn
          label="Cancelar"
          type="reset"
          color="primary"
          class="q-ml-sm"
          :to="{ name: 'home' }"
        />
      </div>
    </q-form>
  </q-page>
</template>
<script setup lang="ts">
import { useQuasar } from 'quasar'
import postService from 'src/services/posts'
import { ref, onMounted } from 'vue'
import { useRoute, useRouter } from 'vue-router'

const { getById, post, update } = postService()

const form = ref({
  formularioId: 0,
  title: '',
  content: '',
  author: '',
})
const router = useRouter()
const route = useRoute()

const $q = useQuasar()

onMounted(async () => {
  // debugger
  // console.log(route.params.id)
  if (route.params.id) {
    getPostId(route.params.id)
  }
})

const getPostId = async (id: any) => {
  // debugger
  try {
    const response = await getById(id)
    console.log(response)
    form.value = response
  } catch (error) {
    console.log(error)
  }
}

const onSubmit = async () => {
  try {
    // Se o id ja eziste então é update
    if (form.value.formularioId) {
      await update(form.value)
    } else {
      await post(form.value)
    }
    $q.notify({
      message: 'Post salvo com sucesso!',
      icon: 'check',
      color: 'positive',
    })
    router.push({ name: 'home' })
  } catch (error) {
    console.error(error)
  }
}
</script>
