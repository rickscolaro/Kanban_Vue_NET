<!-- <template>
  <draggable class="row items-start q-gutter-md" v-model="lists">
    <ListTodo
      :data="list"
      item-key="card.id"
      :key="list.id"
      @delete-list="deleteList"
      class="col"
      v-for="list in lists"
    />

    <q-card class="no-shadow bg-indigo-1 col-auto">
      <q-card-section>
        <!-- New list button -->
        <q-btn
          @click="showNew = true"
          color="primary"
          dense
          flat
          icon="add"
          v-if="!showNew"
        />

        <!-- New list -->
        <q-form @reset="cancelNewList" @submit="newList" v-else>
          <div class="row items-center no-wrap">
            <div class="col q-mr-sm">
              <q-input autofocus dense outlined v-model="newListTitle" />
            </div>
            <div class="col-auto">
              <q-btn color="primary" dense flat icon="close" type="reset" />
              <q-btn color="primary" dense flat icon="done" type="submit" />
            </div>
          </div>
        </q-form>
      </q-card-section>
    </q-card>
  </draggable>
</template>
<script setup>
import draggable from 'vuedraggable'
import ListTodo from './ListTodo.vue'
</script> -->
