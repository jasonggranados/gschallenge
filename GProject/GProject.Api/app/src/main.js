import 'bootstrap';
import $ from 'jquery';

import defaultStore from './user/store';
import UsersPage from './user/users.page';

const usersPage = new UsersPage();

defaultStore.onAssignmentsLoaded(assignments => {
  usersPage.mountAssignments(assignments);
  $('[data-toggle="tooltip"]').tooltip();
});

defaultStore.onUsersLoaded((allUsers) => {
  usersPage.mountUsers(allUsers);
  usersPage.bindUserSelected((usrId) => defaultStore.loadAssignments(usrId));
});

$(() => {
  defaultStore.loadUsers();
})
