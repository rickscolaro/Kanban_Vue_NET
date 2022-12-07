<script setup lang="ts">
import { EnumTodoStatus } from 'src/types/types'
import KanbanGroup from './KanbanGroup.vue'
</script>

<template>
  <div class="q-pa-lg">
    <q-card class="my-card">
      <q-card-section>
        <div class="groups-wrapper">
          <KanbanGroup  :status="EnumTodoStatus.EM_PLANEJAMENTO" title="planejamento" />
          <KanbanGroup :status="EnumTodoStatus.EM_PRODUCAO" title="emproducao"/>
          <KanbanGroup :status="EnumTodoStatus.FINALIZADO" title="finalizado"/>
        </div>
      </q-card-section>
    </q-card>
  </div>
</template>
<style scoped>
.groups-wrapper {
  display: flex;
  justify-content: space-around;
  gap: 20px;
}
</style>
