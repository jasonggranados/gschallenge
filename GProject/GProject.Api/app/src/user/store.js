import { fetchAll, fetchProjects } from './user-client';

function triggerHandlers(handlers, opts) {
  for(const single of handlers) {
    single(opts);
  }
}

class Store {
  constructor(users = [], assignments = new Map()) {
    this.users = users;
    this.assignments = assignments;
    this.onAssignmentsLoadedHandlers = [];
    this.onUsersLoadedHandlers = [];
  }

  loadUsers() {
    fetchAll()
      .then(result => {
        this.users = result;
        triggerHandlers(this.onUsersLoadedHandlers, this.users);
      });
  }

  onUsersLoaded(handler) {
    this.onUsersLoadedHandlers.push(handler);
  }

  onAssignmentsLoaded(handler) {
    this.onAssignmentsLoadedHandlers.push(handler);
  }

  loadAssignments(userId) {
    if (this.assignments.has(userId)) {
      triggerHandlers(this.onAssignmentsLoadedHandlers, this.assignments.get(userId));
      return;
    }

    fetchProjects(userId)
      .then(result => {
        this.assignments.set(userId, result);
        triggerHandlers(this.onAssignmentsLoadedHandlers, this.assignments.get(userId));
      })
  }
}

const defaultStore = new Store();
export default defaultStore;
export {
  Store
}
