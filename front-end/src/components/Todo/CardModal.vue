<!-- <template>
  <q-card style="width: 600px; max-width: 80vw">
    <!--#region Titulo -->
    <q-card-section>
      <div class="col">
        <div @click="editTitle = true" class="text-h6" v-if="!editTitle">
          {{ data.title }}
        </div>
        <q-form
          @reset="cancelNewTitle"
          @submit="saveTitle"
          class="row items-center no-wrap"
          v-else
        >
          <div class="col q-mr-sm">
            <q-input autofocus dense outlined v-model="newTitle" />
          </div>
          <div class="col-auto">
            <q-btn color="primary" dense flat icon="close" type="reset" />
            <q-btn color="primary" dense flat icon="done" type="submit" />
          </div>
        </q-form>
      </div>
    </q-card-section>
    <!--#endregion-->

    <!--#region DeadLine -->
    <q-card-section>
      <div class="row items-center" v-if="!editDeadline">
        <q-icon class="q-mr-xs" name="timer" />
        <span @click="editDeadline = true">{{
          data.duedate || 'Add deadline'
        }}</span>
      </div>
      <q-form
        @reset="cancelNewDeadline"
        @submit="saveDeadline"
        class="row items-center no-wrap"
        v-else
      >
        <div class="col q-mr-sm" style="max-width: 140px">
          <q-input autofocus dense outlined v-model="newDeadline">
            <template v-slot:append>
              <q-icon class="cursor-pointer" name="event">
                <q-popup-proxy
                  ref="qDateProxy"
                  transition-hide="scale"
                  transition-show="scale"
                >
                  <q-date
                    @input="() => $refs.qDateProxy.hide()"
                    mask="DD.MM.YYYY"
                    v-model="newDeadline"
                  />
                </q-popup-proxy>
              </q-icon>
            </template>
          </q-input>
        </div>
        <div class="col-auto">
          <q-btn color="primary" dense flat icon="close" type="reset" />
          <q-btn color="primary" dense flat icon="done" type="submit" />
        </div>
      </q-form>
    </q-card-section>
    <!--#endregion-->

    <!--#region Descrição -->
    <q-card-section>
      <div @click="editDescription = true" v-if="!editDescription">
        {{ data.description }}
      </div>
      <q-form @reset="cancelNewDescription" @submit="saveDescription" v-else>
        <q-input
          autofocus
          dense
          outlined
          type="textarea"
          v-model="newDescription"
        />

        <div class="row items-center q-mt-sm justify-end">
          <q-btn color="primary" dense flat icon="close" type="reset" />
          <q-btn color="primary" dense flat icon="done" type="submit" />
        </div>
      </q-form>
    </q-card-section>
    <!--#endregion-->
  </q-card>
</template>
<script setup lang="ts">
export interface Props {
  data: string[]
}

const props = defineProps<Props>()
</script> -->
