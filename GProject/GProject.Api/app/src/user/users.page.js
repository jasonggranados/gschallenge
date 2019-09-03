import $ from 'jquery';
import { toModel } from './assigment.model';

class UsersPage {
  mountUsers(users = [], targetElementId = '.usr-list__select') {
    const $element = $(targetElementId);
    $element.empty();

    $element.append('<option selected disabled>--</option>');
    for(const single of users) {
      $element.append(` 
        <option value="${single.id}">
          ${single.lastname}, ${single.firstname}
        </option>`);
    }
  }

  bindUserSelected(handler, targetElementId = '.usr-list__select') {
    $(targetElementId).bind('change', function() {
      handler(this.value);
    });
  }

  mountAssignments(assignments = [], targetElementId = '.usr-list__list tbody') {
    const $element = $(targetElementId);
    $element.empty();

    const assignmentsMapped = assignments.map(toModel);

    for(const single of assignmentsMapped) {
      $element.append(`
        <tr>
          <th scope="row">${single.projectId}</th>
          <td>${single.startDate.format('LL')}</td>
          <td>
            ${single.daysToStart < 0 ? 'Started' : single.daysToStart}
            <i class="material-icons md-18 float-right" 
              data-toggle="tooltip" 
              data-placement="top" 
              title="Project was assigned on ${single.assignedDate.format('LL')}">info</i>
          </td>
          <td>${single.endDate.format('LL')}</td>
          <td>${single.credits}</td>
          <td>
            <span class="badge ${single.isActive ? 'badge-info' : 'badge-light'}">
              ${single.status}
            </span>
          </td>
        </tr>`);
    }
  }
}

export default UsersPage;
