<!-- <template>
  <q-card class="no-shadow bg-indigo-1" style="max-width: 380px">
    <q-card-section>
      <div class="row items-center no-wrap">
        <div class="col">
          <div
            @click="editTitle = true"
            class="text-subtitle1 text-weight-medium text-grey-10"
            v-if="!editTitle"
          >
            {{ data.title }}
          </div>
          <!-- Edit list title -->
          <q-form @reset="cancelNewTitle" @submit="saveTitle" v-else>
            <div class="row items-center no-wrap">
              <div class="col q-mr-sm">
                <q-input autofocus dense outlined v-model="newTitle" />
              </div>
              <div class="col-auto">
                <q-btn color="primary" dense flat icon="close" type="reset" />
                <q-btn color="primary" dense flat icon="done" type="submit" />
              </div>
            </div>
          </q-form>
        </div>
        <!-- List actions -->
        <div class="col-auto" v-if="!editTitle">
          <q-btn color="grey-7" dense flat icon="more_horiz">
            <q-menu auto-close>
              <q-list>
                <q-item clickable>
                  <q-item-section @click="newCard(data)"
                    >New card</q-item-section
                  >
                </q-item>
                <q-separator />
                <q-item clickable>
                  <q-item-section @click="deleteList(data)"
                    >Remove list</q-item-section
                  >
                </q-item>
              </q-list>
            </q-menu>
          </q-btn>
        </div>
      </div>
    </q-card-section>
    <!-- Cards -->
    <q-card-section>
      <draggable group="cards">
        <CardTodo :data="card" :key="card.id" v-for="card in data.cards" />
      </draggable>
      <span class="flex justify-center q-mt-md">
        <q-btn @click="newCard(data)" color="primary" dense flat icon="add" />
      </span>
    </q-card-section>
  </q-card>
</template>
<script setup lang="ts">
import Draggable from 'vuedraggable'
import CardTodo from './CardTodo.vue'

export interface Props {
  data: string[]
}

const props = defineProps<Props>()


</script> -->
