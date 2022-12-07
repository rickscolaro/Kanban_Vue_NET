import useApi from '../composables/UseApi'

export default function postService() {
  const { list, post, update, remove, getById } = useApi('produto')

  return {
    list,
    post,
    update,
    remove,
    getById,
  }
}
