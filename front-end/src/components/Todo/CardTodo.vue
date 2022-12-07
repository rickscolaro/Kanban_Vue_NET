<!-- <template>
  <div>
    <q-card @click="openCard = true" class="q-mb-sm">
      <q-card-section>
        <div class="text-body2">{{ data.title }}</div>

        <div
          class="row items-center text-caption text-grey-7 q-pt-xs"
          v-if="data.duedate"
        >
          <q-icon class="q-mr-xs" name="timer" />
          <span>{{ data.duedate }}</span>
        </div>
      </q-card-section>
    </q-card>

    <q-dialog v-model="openCard">
      <CardModal :data="data" />
    </q-dialog>
  </div>
</template>
<script setup lang="ts">
import { data } from 'browserslist'
import { QCard, QCardSection, QIcon, QDialog } from 'quasar'
import { ref } from 'vue'
import CardModal from './CardModal.vue'

const openCard = ref(false)
</script> -->
